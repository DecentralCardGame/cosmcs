// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/evidence/v1beta1/query.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Evidence.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/evidence/v1beta1/query.proto</summary>
  public static partial class QueryReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/evidence/v1beta1/query.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNjb3Ntb3MvZXZpZGVuY2UvdjFiZXRhMS9xdWVyeS5wcm90bxIXY29zbW9z",
            "LmV2aWRlbmNlLnYxYmV0YTEaKmNvc21vcy9iYXNlL3F1ZXJ5L3YxYmV0YTEv",
            "cGFnaW5hdGlvbi5wcm90bxoUZ29nb3Byb3RvL2dvZ28ucHJvdG8aGWdvb2ds",
            "ZS9wcm90b2J1Zi9hbnkucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8ihwEKFFF1ZXJ5RXZpZGVuY2VSZXF1ZXN0ElsKDWV2aWRlbmNlX2hh",
            "c2gYASABKAxCNhgB+t4fMGdpdGh1Yi5jb20vY29tZXRiZnQvY29tZXRiZnQv",
            "bGlicy9ieXRlcy5IZXhCeXRlc1IMZXZpZGVuY2VIYXNoEhIKBGhhc2gYAiAB",
            "KAlSBGhhc2giSQoVUXVlcnlFdmlkZW5jZVJlc3BvbnNlEjAKCGV2aWRlbmNl",
            "GAEgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueVIIZXZpZGVuY2UiYQoXUXVl",
            "cnlBbGxFdmlkZW5jZVJlcXVlc3QSRgoKcGFnaW5hdGlvbhgBIAEoCzImLmNv",
            "c21vcy5iYXNlLnF1ZXJ5LnYxYmV0YTEuUGFnZVJlcXVlc3RSCnBhZ2luYXRp",
            "b24ilQEKGFF1ZXJ5QWxsRXZpZGVuY2VSZXNwb25zZRIwCghldmlkZW5jZRgB",
            "IAMoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnlSCGV2aWRlbmNlEkcKCnBhZ2lu",
            "YXRpb24YAiABKAsyJy5jb3Ntb3MuYmFzZS5xdWVyeS52MWJldGExLlBhZ2VS",
            "ZXNwb25zZVIKcGFnaW5hdGlvbjLFAgoFUXVlcnkSmwEKCEV2aWRlbmNlEi0u",
            "Y29zbW9zLmV2aWRlbmNlLnYxYmV0YTEuUXVlcnlFdmlkZW5jZVJlcXVlc3Qa",
            "Li5jb3Ntb3MuZXZpZGVuY2UudjFiZXRhMS5RdWVyeUV2aWRlbmNlUmVzcG9u",
            "c2UiMILT5JMCKhIoL2Nvc21vcy9ldmlkZW5jZS92MWJldGExL2V2aWRlbmNl",
            "L3toYXNofRKdAQoLQWxsRXZpZGVuY2USMC5jb3Ntb3MuZXZpZGVuY2UudjFi",
            "ZXRhMS5RdWVyeUFsbEV2aWRlbmNlUmVxdWVzdBoxLmNvc21vcy5ldmlkZW5j",
            "ZS52MWJldGExLlF1ZXJ5QWxsRXZpZGVuY2VSZXNwb25zZSIpgtPkkwIjEiEv",
            "Y29zbW9zL2V2aWRlbmNlL3YxYmV0YTEvZXZpZGVuY2VC7QEKG2NvbS5jb3Nt",
            "b3MuZXZpZGVuY2UudjFiZXRhMUIKUXVlcnlQcm90b1ABWkRnaXRodWIuY29t",
            "L2Nvc21vcy9jb3Ntb3Mtc2RrL2Nvc21vcy9ldmlkZW5jZS92MWJldGExO2V2",
            "aWRlbmNldjFiZXRhMaICA0NFWKoCF0Nvc21vcy5FdmlkZW5jZS5WMWJldGEx",
            "ygIXQ29zbW9zXEV2aWRlbmNlXFYxYmV0YTHiAiNDb3Ntb3NcRXZpZGVuY2Vc",
            "VjFiZXRhMVxHUEJNZXRhZGF0YeoCGUNvc21vczo6RXZpZGVuY2U6OlYxYmV0",
            "YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.Base.Query.V1beta1.PaginationReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1beta1.QueryEvidenceRequest), global::Cosmos.Evidence.V1beta1.QueryEvidenceRequest.Parser, new[]{ "EvidenceHash", "Hash" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1beta1.QueryEvidenceResponse), global::Cosmos.Evidence.V1beta1.QueryEvidenceResponse.Parser, new[]{ "Evidence" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1beta1.QueryAllEvidenceRequest), global::Cosmos.Evidence.V1beta1.QueryAllEvidenceRequest.Parser, new[]{ "Pagination" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1beta1.QueryAllEvidenceResponse), global::Cosmos.Evidence.V1beta1.QueryAllEvidenceResponse.Parser, new[]{ "Evidence", "Pagination" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// QueryEvidenceRequest is the request type for the Query/Evidence RPC method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QueryEvidenceRequest : pb::IMessage<QueryEvidenceRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryEvidenceRequest> _parser = new pb::MessageParser<QueryEvidenceRequest>(() => new QueryEvidenceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryEvidenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1beta1.QueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest(QueryEvidenceRequest other) : this() {
      evidenceHash_ = other.evidenceHash_;
      hash_ = other.hash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceRequest Clone() {
      return new QueryEvidenceRequest(this);
    }

    /// <summary>Field number for the "evidence_hash" field.</summary>
    public const int EvidenceHashFieldNumber = 1;
    private pb::ByteString evidenceHash_ = pb::ByteString.Empty;
    /// <summary>
    /// evidence_hash defines the hash of the requested evidence.
    /// Deprecated: Use hash, a HEX encoded string, instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString EvidenceHash {
      get { return evidenceHash_; }
      set {
        evidenceHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 2;
    private string hash_ = "";
    /// <summary>
    /// hash defines the evidence hash of the requested evidence.
    ///
    /// Since: cosmos-sdk 0.47
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryEvidenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryEvidenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EvidenceHash != other.EvidenceHash) return false;
      if (Hash != other.Hash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EvidenceHash.Length != 0) hash ^= EvidenceHash.GetHashCode();
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EvidenceHash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EvidenceHash);
      }
      if (Hash.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Hash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EvidenceHash.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EvidenceHash);
      }
      if (Hash.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Hash);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (EvidenceHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EvidenceHash);
      }
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryEvidenceRequest other) {
      if (other == null) {
        return;
      }
      if (other.EvidenceHash.Length != 0) {
        EvidenceHash = other.EvidenceHash;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            EvidenceHash = input.ReadBytes();
            break;
          }
          case 18: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            EvidenceHash = input.ReadBytes();
            break;
          }
          case 18: {
            Hash = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryEvidenceResponse is the response type for the Query/Evidence RPC method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QueryEvidenceResponse : pb::IMessage<QueryEvidenceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryEvidenceResponse> _parser = new pb::MessageParser<QueryEvidenceResponse>(() => new QueryEvidenceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryEvidenceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1beta1.QueryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse(QueryEvidenceResponse other) : this() {
      evidence_ = other.evidence_ != null ? other.evidence_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryEvidenceResponse Clone() {
      return new QueryEvidenceResponse(this);
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Any evidence_;
    /// <summary>
    /// evidence returns the requested evidence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any Evidence {
      get { return evidence_; }
      set {
        evidence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryEvidenceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryEvidenceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Evidence, other.Evidence)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (evidence_ != null) hash ^= Evidence.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (evidence_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Evidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (evidence_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Evidence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (evidence_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Evidence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryEvidenceResponse other) {
      if (other == null) {
        return;
      }
      if (other.evidence_ != null) {
        if (evidence_ == null) {
          Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Evidence.MergeFrom(other.Evidence);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (evidence_ == null) {
              Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Evidence);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (evidence_ == null) {
              Evidence = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Evidence);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryEvidenceRequest is the request type for the Query/AllEvidence RPC
  /// method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QueryAllEvidenceRequest : pb::IMessage<QueryAllEvidenceRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryAllEvidenceRequest> _parser = new pb::MessageParser<QueryAllEvidenceRequest>(() => new QueryAllEvidenceRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryAllEvidenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1beta1.QueryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest(QueryAllEvidenceRequest other) : this() {
      pagination_ = other.pagination_ != null ? other.pagination_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceRequest Clone() {
      return new QueryAllEvidenceRequest(this);
    }

    /// <summary>Field number for the "pagination" field.</summary>
    public const int PaginationFieldNumber = 1;
    private global::Cosmos.Base.Query.V1beta1.PageRequest pagination_;
    /// <summary>
    /// pagination defines an optional pagination for the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.Query.V1beta1.PageRequest Pagination {
      get { return pagination_; }
      set {
        pagination_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryAllEvidenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryAllEvidenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pagination, other.Pagination)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pagination_ != null) hash ^= Pagination.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (pagination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (pagination_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (pagination_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pagination);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryAllEvidenceRequest other) {
      if (other == null) {
        return;
      }
      if (other.pagination_ != null) {
        if (pagination_ == null) {
          Pagination = new global::Cosmos.Base.Query.V1beta1.PageRequest();
        }
        Pagination.MergeFrom(other.Pagination);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1beta1.PageRequest();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1beta1.PageRequest();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// QueryAllEvidenceResponse is the response type for the Query/AllEvidence RPC
  /// method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QueryAllEvidenceResponse : pb::IMessage<QueryAllEvidenceResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryAllEvidenceResponse> _parser = new pb::MessageParser<QueryAllEvidenceResponse>(() => new QueryAllEvidenceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryAllEvidenceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1beta1.QueryReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse(QueryAllEvidenceResponse other) : this() {
      evidence_ = other.evidence_.Clone();
      pagination_ = other.pagination_ != null ? other.pagination_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryAllEvidenceResponse Clone() {
      return new QueryAllEvidenceResponse(this);
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Protobuf.WellKnownTypes.Any> _repeated_evidence_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Protobuf.WellKnownTypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> evidence_ = new pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any>();
    /// <summary>
    /// evidence returns all evidences.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Protobuf.WellKnownTypes.Any> Evidence {
      get { return evidence_; }
    }

    /// <summary>Field number for the "pagination" field.</summary>
    public const int PaginationFieldNumber = 2;
    private global::Cosmos.Base.Query.V1beta1.PageResponse pagination_;
    /// <summary>
    /// pagination defines the pagination in the response.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.Query.V1beta1.PageResponse Pagination {
      get { return pagination_; }
      set {
        pagination_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryAllEvidenceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryAllEvidenceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!evidence_.Equals(other.evidence_)) return false;
      if (!object.Equals(Pagination, other.Pagination)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= evidence_.GetHashCode();
      if (pagination_ != null) hash ^= Pagination.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      evidence_.WriteTo(output, _repeated_evidence_codec);
      if (pagination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      evidence_.WriteTo(ref output, _repeated_evidence_codec);
      if (pagination_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pagination);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += evidence_.CalculateSize(_repeated_evidence_codec);
      if (pagination_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pagination);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryAllEvidenceResponse other) {
      if (other == null) {
        return;
      }
      evidence_.Add(other.evidence_);
      if (other.pagination_ != null) {
        if (pagination_ == null) {
          Pagination = new global::Cosmos.Base.Query.V1beta1.PageResponse();
        }
        Pagination.MergeFrom(other.Pagination);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            evidence_.AddEntriesFrom(input, _repeated_evidence_codec);
            break;
          }
          case 18: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1beta1.PageResponse();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            evidence_.AddEntriesFrom(ref input, _repeated_evidence_codec);
            break;
          }
          case 18: {
            if (pagination_ == null) {
              Pagination = new global::Cosmos.Base.Query.V1beta1.PageResponse();
            }
            input.ReadMessage(Pagination);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
