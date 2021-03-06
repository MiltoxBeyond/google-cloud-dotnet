// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>Settings for <see cref="BigQueryReadClient"/> instances.</summary>
    public sealed partial class BigQueryReadSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigQueryReadSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigQueryReadSettings"/>.</returns>
        public static BigQueryReadSettings GetDefault() => new BigQueryReadSettings();

        /// <summary>Constructs a new <see cref="BigQueryReadSettings"/> object with default settings.</summary>
        public BigQueryReadSettings()
        {
        }

        private BigQueryReadSettings(BigQueryReadSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateReadSessionSettings = existing.CreateReadSessionSettings;
            ReadRowsSettings = existing.ReadRowsSettings;
            SplitReadStreamSettings = existing.SplitReadStreamSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigQueryReadSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryReadClient.CreateReadSession</c> and <c>BigQueryReadClient.CreateReadSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReadSessionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BigQueryReadClient.ReadRows</c>
        ///  and <c>BigQueryReadClient.ReadRowsAsync</c>.
        /// </summary>
        /// <remarks>Total timeout: 86400 seconds.</remarks>
        public gaxgrpc::CallSettings ReadRowsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryReadClient.SplitReadStream</c> and <c>BigQueryReadClient.SplitReadStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Initial timeout: 600000 milliseconds.</description></item>
        /// <item><description>Timeout multiplier: 1</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Total timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SplitReadStreamSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(retryBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(100), maxDelay: sys::TimeSpan.FromMilliseconds(60000), delayMultiplier: 1.3), timeoutBackoff: new gaxgrpc::BackoffSettings(delay: sys::TimeSpan.FromMilliseconds(600000), maxDelay: sys::TimeSpan.FromMilliseconds(600000), delayMultiplier: 1), totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)), retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable))));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigQueryReadSettings"/> object.</returns>
        public BigQueryReadSettings Clone() => new BigQueryReadSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigQueryReadClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigQueryReadClientBuilder : gaxgrpc::ClientBuilderBase<BigQueryReadClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigQueryReadSettings Settings { get; set; }

        /// <inheritdoc/>
        public override BigQueryReadClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigQueryReadClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<BigQueryReadClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigQueryReadClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => BigQueryReadClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigQueryReadClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigQueryReadClient.ChannelPool;
    }

    /// <summary>BigQueryRead client wrapper, for convenient use.</summary>
    public abstract partial class BigQueryReadClient
    {
        /// <summary>
        /// The default endpoint for the BigQueryRead service, which is a host of "bigquerystorage.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigquerystorage.googleapis.com", 443);

        /// <summary>The default BigQueryRead scopes.</summary>
        /// <remarks>
        /// The default BigQueryRead scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/bigquery.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BigQueryReadClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigQueryReadSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigQueryReadClient"/>.</returns>
        public static async stt::Task<BigQueryReadClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BigQueryReadSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryReadClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigQueryReadSettings"/>.</param>
        /// <returns>The created <see cref="BigQueryReadClient"/>.</returns>
        public static BigQueryReadClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BigQueryReadSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigQueryReadClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigQueryReadSettings"/>.</param>
        /// <returns>The created <see cref="BigQueryReadClient"/>.</returns>
        public static BigQueryReadClient Create(grpccore::Channel channel, BigQueryReadSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BigQueryReadClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigQueryReadSettings"/>.</param>
        /// <returns>The created <see cref="BigQueryReadClient"/>.</returns>
        public static BigQueryReadClient Create(grpccore::CallInvoker callInvoker, BigQueryReadSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigQueryRead.BigQueryReadClient grpcClient = new BigQueryRead.BigQueryReadClient(callInvoker);
            return new BigQueryReadClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,BigQueryReadSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,BigQueryReadSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,BigQueryReadSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,BigQueryReadSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC BigQueryRead client</summary>
        public virtual BigQueryRead.BigQueryReadClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(string parent, ReadSession readSession, int maxStreamCount, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSession(new CreateReadSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReadSession = gax::GaxPreconditions.CheckNotNull(readSession, nameof(readSession)),
                MaxStreamCount = maxStreamCount,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(string parent, ReadSession readSession, int maxStreamCount, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSessionAsync(new CreateReadSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReadSession = gax::GaxPreconditions.CheckNotNull(readSession, nameof(readSession)),
                MaxStreamCount = maxStreamCount,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(string parent, ReadSession readSession, int maxStreamCount, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(parent, readSession, maxStreamCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(gagr::ProjectName parent, ReadSession readSession, int maxStreamCount, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSession(new CreateReadSessionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReadSession = gax::GaxPreconditions.CheckNotNull(readSession, nameof(readSession)),
                MaxStreamCount = maxStreamCount,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(gagr::ProjectName parent, ReadSession readSession, int maxStreamCount, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSessionAsync(new CreateReadSessionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReadSession = gax::GaxPreconditions.CheckNotNull(readSession, nameof(readSession)),
                MaxStreamCount = maxStreamCount,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. The request project that owns the session, in the form of
        /// `projects/{project_id}`.
        /// </param>
        /// <param name="readSession">
        /// Required. Session to be created.
        /// </param>
        /// <param name="maxStreamCount">
        /// Max initial number of streams. If unset or zero, the server will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table. Error
        /// will be returned if the max count is greater than the current system
        /// max limit of 1,000.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(gagr::ProjectName parent, ReadSession readSession, int maxStreamCount, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(parent, readSession, maxStreamCount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ReadRows(ReadRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadRowsStream : gaxgrpc::ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Reads rows from the stream in the format prescribed by the ReadSession.
        /// Each response contains one or more table rows, up to a maximum of 100 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than 100 MiB will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the current
        /// state of the stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads rows from the stream in the format prescribed by the ReadSession.
        /// Each response contains one or more table rows, up to a maximum of 100 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than 100 MiB will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the current
        /// state of the stream.
        /// </summary>
        /// <param name="readStream">
        /// Required. Stream to read rows from.
        /// </param>
        /// <param name="offset">
        /// The offset requested must be less than the last row read from Read.
        /// Requesting a larger offset is undefined. If not specified, start reading
        /// from offset zero.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(string readStream, long offset, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                ReadStream = gax::GaxPreconditions.CheckNotNullOrEmpty(readStream, nameof(readStream)),
                Offset = offset,
            }, callSettings);

        /// <summary>
        /// Reads rows from the stream in the format prescribed by the ReadSession.
        /// Each response contains one or more table rows, up to a maximum of 100 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than 100 MiB will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the current
        /// state of the stream.
        /// </summary>
        /// <param name="readStream">
        /// Required. Stream to read rows from.
        /// </param>
        /// <param name="offset">
        /// The offset requested must be less than the last row read from Read.
        /// Requesting a larger offset is undefined. If not specified, start reading
        /// from offset zero.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadStreamName readStream, long offset, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                ReadStreamAsReadStreamName = gax::GaxPreconditions.CheckNotNull(readStream, nameof(readStream)),
                Offset = offset,
            }, callSettings);

        /// <summary>
        /// Splits a given `ReadStream` into two `ReadStream` objects. These
        /// `ReadStream` objects are referred to as the primary and the residual
        /// streams of the split. The original `ReadStream` can still be read from in
        /// the same manner as before. Both of the returned `ReadStream` objects can
        /// also be read from, and the rows returned by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back-to-back in the
        /// original `ReadStream`. Concretely, it is guaranteed that for streams
        /// original, primary, and residual, that original[0-j] = primary[0-j] and
        /// original[j-n] = residual[0-m] once the streams have been read to
        /// completion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitReadStreamResponse SplitReadStream(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits a given `ReadStream` into two `ReadStream` objects. These
        /// `ReadStream` objects are referred to as the primary and the residual
        /// streams of the split. The original `ReadStream` can still be read from in
        /// the same manner as before. Both of the returned `ReadStream` objects can
        /// also be read from, and the rows returned by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back-to-back in the
        /// original `ReadStream`. Concretely, it is guaranteed that for streams
        /// original, primary, and residual, that original[0-j] = primary[0-j] and
        /// original[j-n] = residual[0-m] once the streams have been read to
        /// completion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits a given `ReadStream` into two `ReadStream` objects. These
        /// `ReadStream` objects are referred to as the primary and the residual
        /// streams of the split. The original `ReadStream` can still be read from in
        /// the same manner as before. Both of the returned `ReadStream` objects can
        /// also be read from, and the rows returned by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back-to-back in the
        /// original `ReadStream`. Concretely, it is guaranteed that for streams
        /// original, primary, and residual, that original[0-j] = primary[0-j] and
        /// original[j-n] = residual[0-m] once the streams have been read to
        /// completion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, st::CancellationToken cancellationToken) =>
            SplitReadStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BigQueryRead client wrapper implementation, for convenient use.</summary>
    public sealed partial class BigQueryReadClientImpl : BigQueryReadClient
    {
        private readonly gaxgrpc::ApiCall<CreateReadSessionRequest, ReadSession> _callCreateReadSession;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;

        private readonly gaxgrpc::ApiCall<SplitReadStreamRequest, SplitReadStreamResponse> _callSplitReadStream;

        /// <summary>
        /// Constructs a client wrapper for the BigQueryRead service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigQueryReadSettings"/> used within this client.</param>
        public BigQueryReadClientImpl(BigQueryRead.BigQueryReadClient grpcClient, BigQueryReadSettings settings)
        {
            GrpcClient = grpcClient;
            BigQueryReadSettings effectiveSettings = settings ?? BigQueryReadSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateReadSession = clientHelper.BuildApiCall<CreateReadSessionRequest, ReadSession>(grpcClient.CreateReadSessionAsync, grpcClient.CreateReadSession, effectiveSettings.CreateReadSessionSettings).WithGoogleRequestParam("read_session.table", request => request.ReadSession?.Table);
            Modify_ApiCall(ref _callCreateReadSession);
            Modify_CreateReadSessionApiCall(ref _callCreateReadSession);
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>(grpcClient.ReadRows, effectiveSettings.ReadRowsSettings);
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            _callSplitReadStream = clientHelper.BuildApiCall<SplitReadStreamRequest, SplitReadStreamResponse>(grpcClient.SplitReadStreamAsync, grpcClient.SplitReadStream, effectiveSettings.SplitReadStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSplitReadStream);
            Modify_SplitReadStreamApiCall(ref _callSplitReadStream);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateReadSessionApiCall(ref gaxgrpc::ApiCall<CreateReadSessionRequest, ReadSession> call);

        partial void Modify_ReadRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);

        partial void Modify_SplitReadStreamApiCall(ref gaxgrpc::ApiCall<SplitReadStreamRequest, SplitReadStreamResponse> call);

        partial void OnConstruction(BigQueryRead.BigQueryReadClient grpcClient, BigQueryReadSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigQueryRead client</summary>
        public override BigQueryRead.BigQueryReadClient GrpcClient { get; }

        partial void Modify_CreateReadSessionRequest(ref CreateReadSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SplitReadStreamRequest(ref SplitReadStreamRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadSession CreateReadSession(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReadSessionRequest(ref request, ref callSettings);
            return _callCreateReadSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Data is assigned to each stream such that roughly the same number of
        /// rows can be read from each stream. Because the server-side unit for
        /// assigning data is collections of rows, the API does not guarantee that
        /// each stream will return the same number or rows. Additionally, the
        /// limits are enforced based on the number of pre-filtered rows, so some
        /// filters can lead to lopsided assignments.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReadSessionRequest(ref request, ref callSettings);
            return _callCreateReadSession.Async(request, callSettings);
        }

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>Construct the server streaming method for <c>ReadRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadRowsStreamImpl(grpccore::AsyncServerStreamingCall<ReadRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }

            public override scg::IAsyncEnumerator<ReadRowsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Reads rows from the stream in the format prescribed by the ReadSession.
        /// Each response contains one or more table rows, up to a maximum of 100 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than 100 MiB will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the current
        /// state of the stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigQueryReadClient.ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        /// <summary>
        /// Splits a given `ReadStream` into two `ReadStream` objects. These
        /// `ReadStream` objects are referred to as the primary and the residual
        /// streams of the split. The original `ReadStream` can still be read from in
        /// the same manner as before. Both of the returned `ReadStream` objects can
        /// also be read from, and the rows returned by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back-to-back in the
        /// original `ReadStream`. Concretely, it is guaranteed that for streams
        /// original, primary, and residual, that original[0-j] = primary[0-j] and
        /// original[j-n] = residual[0-m] once the streams have been read to
        /// completion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SplitReadStreamResponse SplitReadStream(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitReadStreamRequest(ref request, ref callSettings);
            return _callSplitReadStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Splits a given `ReadStream` into two `ReadStream` objects. These
        /// `ReadStream` objects are referred to as the primary and the residual
        /// streams of the split. The original `ReadStream` can still be read from in
        /// the same manner as before. Both of the returned `ReadStream` objects can
        /// also be read from, and the rows returned by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back-to-back in the
        /// original `ReadStream`. Concretely, it is guaranteed that for streams
        /// original, primary, and residual, that original[0-j] = primary[0-j] and
        /// original[j-n] = residual[0-m] once the streams have been read to
        /// completion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitReadStreamRequest(ref request, ref callSettings);
            return _callSplitReadStream.Async(request, callSettings);
        }
    }
}
