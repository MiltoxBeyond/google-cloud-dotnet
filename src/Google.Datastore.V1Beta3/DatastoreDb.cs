﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Protobuf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Google.Datastore.V1Beta3.CommitRequest.Types;
using static Google.Datastore.V1Beta3.QueryResultBatch.Types;
using static Google.Datastore.V1Beta3.ReadOptions.Types;

namespace Google.Datastore.V1Beta3
{
    // Partial classes to allow page streaming, admittedly slightly unusually.
    public partial class RunQueryResponse : IPageResponse<Entity>
    {
        string IPageResponse<Entity>.NextPageToken => Batch.MoreResults == MoreResultsType.NoMoreResults ? "" : Batch.EndCursor.ToBase64();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<Entity>)this).GetEnumerator();

        IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator() => Batch.EntityResults.Select(result => result.Entity).GetEnumerator();
    }

    public partial class RunQueryRequest : IPageRequest
    {
        int IPageRequest.PageSize
        {
            set
            {
                if (Query != null)
                {
                    Query.Limit = value;
                }
                else
                {
                    throw new InvalidOperationException("Only structured queries are currently supported for automatic page streaming");
                }
            }
        }
        string IPageRequest.PageToken
        {
            set
            {
                if (Query != null)
                {
                    Query.StartCursor = ByteString.FromBase64(value);
                }
                else
                {
                    throw new InvalidOperationException("Only structured queries are currently supported for automatic page streaming");
                }
            }
        }
    }

    public partial class DatastoreClient
    {
        // Allows us to use page streaming from the abstraction below.
        internal virtual ApiCall<RunQueryRequest, RunQueryResponse> RunQueryApiCall { get { throw new NotImplementedException(); } }
    }

    public partial class DatastoreClientImpl
    {
        internal override ApiCall<RunQueryRequest, RunQueryResponse> RunQueryApiCall => _callRunQuery;
    }

    /// <summary>
    /// An abstraction over <see cref="DatastoreClient"/> to simplify operations. Use the <see cref="Create(string, string, DatastoreClient)"/>
    /// method to obtain an instance of this class.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The project ID specified on creation is used for all operations, effectively supplying the first parameter of every
    /// operation specified on <see cref="DatastoreClient"/>.
    /// </para>
    /// <para>
    /// The project ID and namespace ID are combined to form a partition ID. This partition ID is used when creating a key
    /// factory or running a query. Operations that take keys or entities do not validate that the keys are within the
    /// partition associated with this object.
    /// </para>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(string, string, DatastoreClient)"/>
    /// to construct instances; alternatively, you can construct a <see cref="DatastoreClient"/> directly.
    /// </para>
    /// </remarks>
    public abstract class DatastoreDb
    {
        /// <summary>
        /// The <see cref="DatastoreClient"/> used for all remote operations.
        /// </summary>
        public virtual DatastoreClient Client { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the project this instance operates on.
        /// </summary>
        public virtual string ProjectId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the namespace this instance operates on.
        /// </summary>
        public virtual string NamespaceId { get { throw new NotImplementedException(); } }


        /// <summary>
        /// Creates a <see cref="DatastoreDb"/> to operate on the partition identified by <paramref name="projectId"/>
        /// and <paramref name="namespaceId"/>, using the <paramref name="client"/> to perform remote operations.
        /// </summary>
        /// <param name="projectId">The project ID to use in all operations.</param>
        /// <param name="namespaceId">The namespace ID to use in operations requiring a partition.</param>
        /// <param name="client">The client to use for remote operations. If this is null, an instance will be created
        /// using default settings.</param>
        /// <returns>A <see cref="DatastoreDb"/> operating on the specified partition.</returns>
        public static DatastoreDb Create(string projectId, string namespaceId = "", DatastoreClient client = null) =>
            new DatastoreDbImpl(projectId, namespaceId, client ?? DatastoreClient.Create());

        public DatastoreDb()
        {
        }

        /// <summary>
        /// Creates a key factory for root entities in this objects's partition.
        /// </summary>
        /// <param name="kind">The kind of entity key to create. Must not be null.</param>
        /// <returns>A key factory with the specified kind and this object's partition.</returns>
        public virtual KeyFactory CreateKeyFactory(string kind)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Perform a single <see cref="DatastoreClient.RunQuery(string, PartitionId, ReadOptions, Query, CallSettings)"/> operation
        /// using this object's partition ID and the specified read consistency, not in a transaction.
        /// </summary>
        /// <remarks>
        /// To automatically stream pages of results, use <see cref="RunQueryPageStream(Query, ReadConsistency?)"/>.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">The desired read consistency of the query, or null to use the default.</param>
        /// <returns>The response for the given query operation.</returns>
        public virtual RunQueryResponse RunQuery(Query query, ReadConsistency? readConsistency = null)
        {
            throw new NotImplementedException();
        }

        // Note: no pagestreaming yet for GQL as it's tough to modify the limit/offset automatically.

        /// <summary>
        /// Perform a single <see cref="DatastoreClient.RunQuery(string, PartitionId, ReadOptions, Query, CallSettings)"/> operation
        /// using this object's partition ID and the specified read consistency, not in a transaction.
        /// </summary>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">The desired read consistency of the query, or null to use the default.</param>
        /// <returns>The response for the given query operation.</returns>
        public virtual RunQueryResponse RunQuery(GqlQuery query, ReadConsistency? readConsistency = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Executes the given query, automatically streaming the pages of results.
        /// </summary>
        /// <remarks>
        /// To start where a previous operation left off, specify <see cref="Query.StartCursor"/>.
        /// If you have been using <see cref="FixedSizePage{Entity}"/>, convert the <see cref="FixedSizePage{TResource}.NextPageToken"/>
        /// string into a <see cref="ByteString"/> using <see cref="ByteString.FromBase64(string)"/>.
        /// </remarks>
        /// <param name="query">The query to execute. Must not be null.</param>
        /// <param name="readConsistency">The desired read consistency of the query, or null to use
        /// the default.</param>
        /// <returns>A sequence of pages of entities.</returns>
        public virtual IPagedEnumerable<RunQueryResponse, Entity> RunQueryPageStream(Query query, ReadConsistency? readConsistency = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Begins a transaction, returning a <see cref="DatastoreTransaction"/> which can be used to operate on the transaction.
        /// </summary>
        /// <returns>A new <see cref="DatastoreTransaction"/> for this object's project.</returns>
        public virtual DatastoreTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allocates an ID for a single incomplete key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="AllocateIds(Key[])"/>.</remarks>
        /// <param name="key">The incomplete key to allocate an ID for.</param>
        /// <returns>The complete key.</returns>
        public Key AllocateId(Key key) => AllocateIds(new[] { key })[0];

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="AllocateIds(IEnumerable{Key})"/>.</remarks>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public IReadOnlyList<Key> AllocateIds(params Key[] keys) => AllocateIds((IEnumerable<Key>)keys);

        /// <summary>
        /// Allocates IDs for a collection of incomplete keys.
        /// </summary>
        /// <param name="keys">The incomplete keys. Must not be null or contain null elements.</param>
        /// <returns>A collection of complete keys with allocated IDs, in the same order as <paramref name="keys"/>.</returns>
        public virtual IReadOnlyList<Key> AllocateIds(IEnumerable<Key> keys)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Looks up a single entity by key.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Lookup(IEnumerable{Key}, ReadConsistency?)"/>.</remarks>
        /// <param name="key">The key to look up. Must not be null, and must be complete.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <returns>The entity with the specified key, or <c>null</c> if no such entity exists.</returns>
        public Entity Lookup(Key key, ReadConsistency? readConsistency = null) => Lookup(new[] { key }, readConsistency)[0];

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <remarks>
        /// This overload does not support the <see cref="ReadConsistency"/> to be specified due to restrictions with
        /// methods containing a parameter array and optional parameters.
        /// It simply delegates to <see cref="Lookup(IEnumerable{Key}, ReadConsistency?)"/>, passing in a <c>null</c>
        /// value for the read consistency.
        /// </remarks>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public IReadOnlyList<Entity> Lookup(params Key[] keys) => Lookup(keys, null);

        /// <summary>
        /// Looks up a collection of entities by key.
        /// </summary>
        /// <param name="keys">The keys to look up. Must not be null, and every element must be non-null and refer to a complete key.</param>
        /// <param name="readConsistency">The desired read consistency of the lookup, or null to use the default.</param>
        /// <returns>A collection of entities with the same size as <paramref name="keys"/>, containing corresponding entity
        /// references, or <c>null</c> where the key was not found.</returns>
        public virtual IReadOnlyList<Entity> Lookup(IEnumerable<Key> keys, ReadConsistency? readConsistency = null)
        {
            throw new NotImplementedException();
        }

        // Static to allow reuse within DatastoreTransaction.
        internal static IReadOnlyList<Entity> LookupImpl(DatastoreClient client, string projectId, ReadOptions readOptions, IEnumerable<Key> keys)
        {
            // Just so we can iterate multiple times safely.
            keys = keys.ToList();
            GaxPreconditions.CheckArgument(keys.All(x => x != null), nameof(keys), "Key collection must not contain null elements");
            var keyToIndex = keys.Select((value, index) => new { value, index }).ToLookup(pair => pair.value, pair => pair.index);
            IEnumerable<Key> keysToFetch = new HashSet<Key>(keys);
            Entity[] result = new Entity[keys.Count()];
            // TODO: Limit how many times we go round? Ensure that we make progress on each iteration?
            while (keysToFetch.Count() > 0)
            {
                var response = client.Lookup(projectId, readOptions, keysToFetch);
                foreach (var found in response.Found)
                {
                    foreach (var index in keyToIndex[found.Entity.Key])
                    {
                        result[index] = found.Entity;
                    }
                }
                keysToFetch = response.Deferred;
            }
            return result;
        }

        // Non-transactional mutations

        /// <summary>
        /// Inserts a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Insert(Entity[])"/>.</remarks>
        /// <param name="entity">The entity to insert. Must not be null.</param>
        /// <returns>The key of the inserted entity.</returns>
        public Key Insert(Entity entity) => Insert(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) })[0];
        /// <summary>
        /// Inserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Insert(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of inserted entities, in the same order as <paramref name="entities"/>.</returns>
        public IReadOnlyList<Key> Insert(params Entity[] entities) => Insert((IEnumerable<Entity>) entities);
        /// <summary>
        /// Inserts a collection of entities, non-transactionally.
        /// </summary>
        /// <param name="entities">The entities to insert. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of inserted entities, in the same order as <paramref name="entities"/>.</returns>
        public virtual IReadOnlyList<Key> Insert(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Upserts a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Upsert(Entity[])"/>.</remarks>
        /// <param name="entity">The entity to upsert. Must not be null.</param>
        /// <returns>The key of the upserted entity.</returns>
        public Key Upsert(Entity entity) => Upsert(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) })[0];
        /// <summary>
        /// Upserts a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Upsert(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of upserted entities, in the same order as <paramref name="entities"/>.</returns>
        public IReadOnlyList<Key> Upsert(params Entity[] entities) => Upsert((IEnumerable<Entity>) entities);
        /// <summary>
        /// Upserts a collection of entities, non-transactionally.
        /// </summary>
        /// <param name="entities">The entities to upsert. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of upserted entities, in the same order as <paramref name="entities"/>.</returns>
        public virtual IReadOnlyList<Key> Upsert(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Update(Entity[])"/>.</remarks>
        /// <param name="entity">The entity to update. Must not be null.</param>
        /// <returns>The key of the updated entity.</returns>
        public Key Update(Entity entity) => Update(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) })[0];
        /// <summary>
        /// Updates a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Update(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of updated entities, in the same order as <paramref name="entities"/>.</returns>
        public IReadOnlyList<Key> Update(params Entity[] entities) => Update((IEnumerable<Entity>) entities);
        /// <summary>
        /// Updates a collection of entities, non-transactionally.
        /// </summary>
        /// <param name="entities">The entities to update. Must not be null or contain null entries.</param>
        /// <returns>A collection of keys of updated entities, in the same order as <paramref name="entities"/>.</returns>
        public virtual IReadOnlyList<Key> Update(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single entity, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(Entity[])"/>.</remarks>
        /// <param name="entity">The entity to delete. Must not be null.</param>
        public void Delete(Entity entity) => Delete(new[] { GaxPreconditions.CheckNotNull(entity, nameof(entity)) });
        /// <summary>
        /// Deletes a collection of entities, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(IEnumerable{Entity})"/>.</remarks>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        public void Delete(params Entity[] entities) => Delete((IEnumerable<Entity>) entities);
        /// <summary>
        /// Deletes a collection of entities, non-transactionally.
        /// </summary>
        /// <param name="entities">The entities to delete. Must not be null or contain null entries.</param>
        public virtual void Delete(IEnumerable<Entity> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a single key, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(Key[])"/>.</remarks>
        /// <param name="key">The key to delete. Must not be null.</param>
        public void Delete(Key key) => Delete(new[] { GaxPreconditions.CheckNotNull(key, nameof(key)) });
        /// <summary>
        /// Deletes a collection of keys, non-transactionally.
        /// </summary>
        /// <remarks>This method simply delegates to <see cref="Delete(IEnumerable{Key})"/>.</remarks>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        public void Delete(params Key[] keys) => Delete((IEnumerable<Key>) keys);
        /// <summary>
        /// Deletes a collection of keys, non-transactionally.
        /// </summary>
        /// <param name="keys">The keys to delete. Must not be null or contain null entries.</param>
        public virtual void Delete(IEnumerable<Key> keys)
        {
            throw new NotImplementedException();
        }
    }
}
