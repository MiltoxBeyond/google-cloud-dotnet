// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/text_segment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/text_segment.proto</summary>
  public static partial class TextSegmentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/text_segment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextSegmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RleHRfc2VnbWVudC5wcm90bxIW",
            "Z29vZ2xlLmNsb3VkLmF1dG9tbC52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byJICgtUZXh0U2VnbWVudBIPCgdjb250ZW50GAMgASgJEhQKDHN0",
            "YXJ0X29mZnNldBgBIAEoAxISCgplbmRfb2Zmc2V0GAIgASgDQrwBChpjb20u",
            "Z29vZ2xlLmNsb3VkLmF1dG9tbC52MUIQVGV4dFNlZ21lbnRQcm90b1ABWjxn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2F1",
            "dG9tbC92MTthdXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0b01MLlYxygIWR29v",
            "Z2xlXENsb3VkXEF1dG9NbFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9NTDo6",
            "VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextSegment), global::Google.Cloud.AutoML.V1.TextSegment.Parser, new[]{ "Content", "StartOffset", "EndOffset" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A contiguous part of a text (string), assuming it has an UTF-8 NFC encoding.
  /// </summary>
  public sealed partial class TextSegment : pb::IMessage<TextSegment> {
    private static readonly pb::MessageParser<TextSegment> _parser = new pb::MessageParser<TextSegment>(() => new TextSegment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TextSegment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TextSegmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextSegment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextSegment(TextSegment other) : this() {
      content_ = other.content_;
      startOffset_ = other.startOffset_;
      endOffset_ = other.endOffset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TextSegment Clone() {
      return new TextSegment(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private string content_ = "";
    /// <summary>
    /// Output only. The content of the TextSegment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "start_offset" field.</summary>
    public const int StartOffsetFieldNumber = 1;
    private long startOffset_;
    /// <summary>
    /// Required. Zero-based character index of the first character of the text
    /// segment (counting characters from the beginning of the text).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StartOffset {
      get { return startOffset_; }
      set {
        startOffset_ = value;
      }
    }

    /// <summary>Field number for the "end_offset" field.</summary>
    public const int EndOffsetFieldNumber = 2;
    private long endOffset_;
    /// <summary>
    /// Required. Zero-based character index of the first character past the end of
    /// the text segment (counting character from the beginning of the text).
    /// The character at the end_offset is NOT included in the text segment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long EndOffset {
      get { return endOffset_; }
      set {
        endOffset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TextSegment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TextSegment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (StartOffset != other.StartOffset) return false;
      if (EndOffset != other.EndOffset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (StartOffset != 0L) hash ^= StartOffset.GetHashCode();
      if (EndOffset != 0L) hash ^= EndOffset.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StartOffset != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(StartOffset);
      }
      if (EndOffset != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(EndOffset);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (StartOffset != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartOffset);
      }
      if (EndOffset != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndOffset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TextSegment other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.StartOffset != 0L) {
        StartOffset = other.StartOffset;
      }
      if (other.EndOffset != 0L) {
        EndOffset = other.EndOffset;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StartOffset = input.ReadInt64();
            break;
          }
          case 16: {
            EndOffset = input.ReadInt64();
            break;
          }
          case 26: {
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
