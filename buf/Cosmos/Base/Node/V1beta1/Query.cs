// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/base/node/v1beta1/query.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Base.Node.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/base/node/v1beta1/query.proto</summary>
  public static partial class QueryReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/base/node/v1beta1/query.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRjb3Ntb3MvYmFzZS9ub2RlL3YxYmV0YTEvcXVlcnkucHJvdG8SGGNvc21v",
            "cy5iYXNlLm5vZGUudjFiZXRhMRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxoUZ29nb3By",
            "b3RvL2dvZ28ucHJvdG8iDwoNQ29uZmlnUmVxdWVzdCKXAQoOQ29uZmlnUmVz",
            "cG9uc2USKgoRbWluaW11bV9nYXNfcHJpY2UYASABKAlSD21pbmltdW1HYXNQ",
            "cmljZRIuChNwcnVuaW5nX2tlZXBfcmVjZW50GAIgASgJUhFwcnVuaW5nS2Vl",
            "cFJlY2VudBIpChBwcnVuaW5nX2ludGVydmFsGAMgASgJUg9wcnVuaW5nSW50",
            "ZXJ2YWwiDwoNU3RhdHVzUmVxdWVzdCLeAQoOU3RhdHVzUmVzcG9uc2USMgoV",
            "ZWFybGllc3Rfc3RvcmVfaGVpZ2h0GAEgASgEUhNlYXJsaWVzdFN0b3JlSGVp",
            "Z2h0EhYKBmhlaWdodBgCIAEoBFIGaGVpZ2h0Ej4KCXRpbWVzdGFtcBgDIAEo",
            "CzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCBJDfHwFSCXRpbWVzdGFt",
            "cBIZCghhcHBfaGFzaBgEIAEoDFIHYXBwSGFzaBIlCg52YWxpZGF0b3JfaGFz",
            "aBgFIAEoDFINdmFsaWRhdG9ySGFzaDKZAgoHU2VydmljZRKFAQoGQ29uZmln",
            "EicuY29zbW9zLmJhc2Uubm9kZS52MWJldGExLkNvbmZpZ1JlcXVlc3QaKC5j",
            "b3Ntb3MuYmFzZS5ub2RlLnYxYmV0YTEuQ29uZmlnUmVzcG9uc2UiKILT5JMC",
            "IhIgL2Nvc21vcy9iYXNlL25vZGUvdjFiZXRhMS9jb25maWcShQEKBlN0YXR1",
            "cxInLmNvc21vcy5iYXNlLm5vZGUudjFiZXRhMS5TdGF0dXNSZXF1ZXN0Gigu",
            "Y29zbW9zLmJhc2Uubm9kZS52MWJldGExLlN0YXR1c1Jlc3BvbnNlIiiC0+ST",
            "AiISIC9jb3Ntb3MvYmFzZS9ub2RlL3YxYmV0YTEvc3RhdHVzQtwBChxjb20u",
            "Y29zbW9zLmJhc2Uubm9kZS52MWJldGExQgpRdWVyeVByb3RvUAFaLWdpdGh1",
            "Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvY2xpZW50L2dycGMvbm9kZaICA0NC",
            "TqoCGENvc21vcy5CYXNlLk5vZGUuVjFiZXRhMcoCGENvc21vc1xCYXNlXE5v",
            "ZGVcVjFiZXRhMeICJENvc21vc1xCYXNlXE5vZGVcVjFiZXRhMVxHUEJNZXRh",
            "ZGF0YeoCG0Nvc21vczo6QmFzZTo6Tm9kZTo6VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Base.Node.V1beta1.ConfigRequest), global::Cosmos.Base.Node.V1beta1.ConfigRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Base.Node.V1beta1.ConfigResponse), global::Cosmos.Base.Node.V1beta1.ConfigResponse.Parser, new[]{ "MinimumGasPrice", "PruningKeepRecent", "PruningInterval" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Base.Node.V1beta1.StatusRequest), global::Cosmos.Base.Node.V1beta1.StatusRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Base.Node.V1beta1.StatusResponse), global::Cosmos.Base.Node.V1beta1.StatusResponse.Parser, new[]{ "EarliestStoreHeight", "Height", "Timestamp", "AppHash", "ValidatorHash" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// ConfigRequest defines the request structure for the Config gRPC query.
  /// </summary>
  public sealed partial class ConfigRequest : pb::IMessage<ConfigRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConfigRequest> _parser = new pb::MessageParser<ConfigRequest>(() => new ConfigRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConfigRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Base.Node.V1beta1.QueryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigRequest(ConfigRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigRequest Clone() {
      return new ConfigRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConfigRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConfigRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConfigRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// ConfigResponse defines the response structure for the Config gRPC query.
  /// </summary>
  public sealed partial class ConfigResponse : pb::IMessage<ConfigResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConfigResponse> _parser = new pb::MessageParser<ConfigResponse>(() => new ConfigResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConfigResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Base.Node.V1beta1.QueryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigResponse(ConfigResponse other) : this() {
      minimumGasPrice_ = other.minimumGasPrice_;
      pruningKeepRecent_ = other.pruningKeepRecent_;
      pruningInterval_ = other.pruningInterval_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigResponse Clone() {
      return new ConfigResponse(this);
    }

    /// <summary>Field number for the "minimum_gas_price" field.</summary>
    public const int MinimumGasPriceFieldNumber = 1;
    private string minimumGasPrice_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MinimumGasPrice {
      get { return minimumGasPrice_; }
      set {
        minimumGasPrice_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pruning_keep_recent" field.</summary>
    public const int PruningKeepRecentFieldNumber = 2;
    private string pruningKeepRecent_ = "";
    /// <summary>
    /// pruning settings
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PruningKeepRecent {
      get { return pruningKeepRecent_; }
      set {
        pruningKeepRecent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pruning_interval" field.</summary>
    public const int PruningIntervalFieldNumber = 3;
    private string pruningInterval_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PruningInterval {
      get { return pruningInterval_; }
      set {
        pruningInterval_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConfigResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConfigResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinimumGasPrice != other.MinimumGasPrice) return false;
      if (PruningKeepRecent != other.PruningKeepRecent) return false;
      if (PruningInterval != other.PruningInterval) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinimumGasPrice.Length != 0) hash ^= MinimumGasPrice.GetHashCode();
      if (PruningKeepRecent.Length != 0) hash ^= PruningKeepRecent.GetHashCode();
      if (PruningInterval.Length != 0) hash ^= PruningInterval.GetHashCode();
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
      if (MinimumGasPrice.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MinimumGasPrice);
      }
      if (PruningKeepRecent.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PruningKeepRecent);
      }
      if (PruningInterval.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PruningInterval);
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
      if (MinimumGasPrice.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MinimumGasPrice);
      }
      if (PruningKeepRecent.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PruningKeepRecent);
      }
      if (PruningInterval.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PruningInterval);
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
      if (MinimumGasPrice.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MinimumGasPrice);
      }
      if (PruningKeepRecent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PruningKeepRecent);
      }
      if (PruningInterval.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PruningInterval);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConfigResponse other) {
      if (other == null) {
        return;
      }
      if (other.MinimumGasPrice.Length != 0) {
        MinimumGasPrice = other.MinimumGasPrice;
      }
      if (other.PruningKeepRecent.Length != 0) {
        PruningKeepRecent = other.PruningKeepRecent;
      }
      if (other.PruningInterval.Length != 0) {
        PruningInterval = other.PruningInterval;
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
            MinimumGasPrice = input.ReadString();
            break;
          }
          case 18: {
            PruningKeepRecent = input.ReadString();
            break;
          }
          case 26: {
            PruningInterval = input.ReadString();
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
            MinimumGasPrice = input.ReadString();
            break;
          }
          case 18: {
            PruningKeepRecent = input.ReadString();
            break;
          }
          case 26: {
            PruningInterval = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// StateRequest defines the request structure for the status of a node.
  /// </summary>
  public sealed partial class StatusRequest : pb::IMessage<StatusRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StatusRequest> _parser = new pb::MessageParser<StatusRequest>(() => new StatusRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Base.Node.V1beta1.QueryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusRequest(StatusRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusRequest Clone() {
      return new StatusRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StatusRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StatusRequest other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// StateResponse defines the response structure for the status of a node.
  /// </summary>
  public sealed partial class StatusResponse : pb::IMessage<StatusResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StatusResponse> _parser = new pb::MessageParser<StatusResponse>(() => new StatusResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Base.Node.V1beta1.QueryReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusResponse(StatusResponse other) : this() {
      earliestStoreHeight_ = other.earliestStoreHeight_;
      height_ = other.height_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      appHash_ = other.appHash_;
      validatorHash_ = other.validatorHash_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StatusResponse Clone() {
      return new StatusResponse(this);
    }

    /// <summary>Field number for the "earliest_store_height" field.</summary>
    public const int EarliestStoreHeightFieldNumber = 1;
    private ulong earliestStoreHeight_;
    /// <summary>
    /// earliest block height available in the store
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong EarliestStoreHeight {
      get { return earliestStoreHeight_; }
      set {
        earliestStoreHeight_ = value;
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 2;
    private ulong height_;
    /// <summary>
    /// current block height
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// block height timestamp
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "app_hash" field.</summary>
    public const int AppHashFieldNumber = 4;
    private pb::ByteString appHash_ = pb::ByteString.Empty;
    /// <summary>
    /// app hash of the current block
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString AppHash {
      get { return appHash_; }
      set {
        appHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "validator_hash" field.</summary>
    public const int ValidatorHashFieldNumber = 5;
    private pb::ByteString validatorHash_ = pb::ByteString.Empty;
    /// <summary>
    /// validator hash provided by the consensus header
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ValidatorHash {
      get { return validatorHash_; }
      set {
        validatorHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StatusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EarliestStoreHeight != other.EarliestStoreHeight) return false;
      if (Height != other.Height) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (AppHash != other.AppHash) return false;
      if (ValidatorHash != other.ValidatorHash) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EarliestStoreHeight != 0UL) hash ^= EarliestStoreHeight.GetHashCode();
      if (Height != 0UL) hash ^= Height.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (AppHash.Length != 0) hash ^= AppHash.GetHashCode();
      if (ValidatorHash.Length != 0) hash ^= ValidatorHash.GetHashCode();
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
      if (EarliestStoreHeight != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EarliestStoreHeight);
      }
      if (Height != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Height);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timestamp);
      }
      if (AppHash.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(AppHash);
      }
      if (ValidatorHash.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(ValidatorHash);
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
      if (EarliestStoreHeight != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(EarliestStoreHeight);
      }
      if (Height != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Height);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timestamp);
      }
      if (AppHash.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(AppHash);
      }
      if (ValidatorHash.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(ValidatorHash);
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
      if (EarliestStoreHeight != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(EarliestStoreHeight);
      }
      if (Height != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Height);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (AppHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(AppHash);
      }
      if (ValidatorHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ValidatorHash);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StatusResponse other) {
      if (other == null) {
        return;
      }
      if (other.EarliestStoreHeight != 0UL) {
        EarliestStoreHeight = other.EarliestStoreHeight;
      }
      if (other.Height != 0UL) {
        Height = other.Height;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.AppHash.Length != 0) {
        AppHash = other.AppHash;
      }
      if (other.ValidatorHash.Length != 0) {
        ValidatorHash = other.ValidatorHash;
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
          case 8: {
            EarliestStoreHeight = input.ReadUInt64();
            break;
          }
          case 16: {
            Height = input.ReadUInt64();
            break;
          }
          case 26: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 34: {
            AppHash = input.ReadBytes();
            break;
          }
          case 42: {
            ValidatorHash = input.ReadBytes();
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
          case 8: {
            EarliestStoreHeight = input.ReadUInt64();
            break;
          }
          case 16: {
            Height = input.ReadUInt64();
            break;
          }
          case 26: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 34: {
            AppHash = input.ReadBytes();
            break;
          }
          case 42: {
            ValidatorHash = input.ReadBytes();
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