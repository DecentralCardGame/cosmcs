// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/consensus/v1/tx.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Consensus.V1 {

  /// <summary>Holder for reflection information generated from cosmos/consensus/v1/tx.proto</summary>
  public static partial class TxReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/consensus/v1/tx.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TxReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxjb3Ntb3MvY29uc2Vuc3VzL3YxL3R4LnByb3RvEhNjb3Ntb3MuY29uc2Vu",
            "c3VzLnYxGhljb3Ntb3NfcHJvdG8vY29zbW9zLnByb3RvGhdjb3Ntb3MvbXNn",
            "L3YxL21zZy5wcm90bxoddGVuZGVybWludC90eXBlcy9wYXJhbXMucHJvdG8i",
            "jQIKD01zZ1VwZGF0ZVBhcmFtcxI2CglhdXRob3JpdHkYASABKAlCGNK0LRRj",
            "b3Ntb3MuQWRkcmVzc1N0cmluZ1IJYXV0aG9yaXR5EjMKBWJsb2NrGAIgASgL",
            "Mh0udGVuZGVybWludC50eXBlcy5CbG9ja1BhcmFtc1IFYmxvY2sSPAoIZXZp",
            "ZGVuY2UYAyABKAsyIC50ZW5kZXJtaW50LnR5cGVzLkV2aWRlbmNlUGFyYW1z",
            "UghldmlkZW5jZRI/Cgl2YWxpZGF0b3IYBCABKAsyIS50ZW5kZXJtaW50LnR5",
            "cGVzLlZhbGlkYXRvclBhcmFtc1IJdmFsaWRhdG9yOg6C57AqCWF1dGhvcml0",
            "eSIZChdNc2dVcGRhdGVQYXJhbXNSZXNwb25zZTJpCgNNc2cSYgoMVXBkYXRl",
            "UGFyYW1zEiQuY29zbW9zLmNvbnNlbnN1cy52MS5Nc2dVcGRhdGVQYXJhbXMa",
            "LC5jb3Ntb3MuY29uc2Vuc3VzLnYxLk1zZ1VwZGF0ZVBhcmFtc1Jlc3BvbnNl",
            "Qs4BChdjb20uY29zbW9zLmNvbnNlbnN1cy52MUIHVHhQcm90b1ABWjxnaXRo",
            "dWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL2Nvc21vcy9jb25zZW5zdXMvdjE7",
            "Y29uc2Vuc3VzdjGiAgNDQ1iqAhNDb3Ntb3MuQ29uc2Vuc3VzLlYxygITQ29z",
            "bW9zXENvbnNlbnN1c1xWMeICH0Nvc21vc1xDb25zZW5zdXNcVjFcR1BCTWV0",
            "YWRhdGHqAhVDb3Ntb3M6OkNvbnNlbnN1czo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CosmosProto.CosmosReflection.Descriptor, global::Cosmos.Msg.V1.MsgReflection.Descriptor, global::Tendermint.Types.ParamsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Consensus.V1.MsgUpdateParams), global::Cosmos.Consensus.V1.MsgUpdateParams.Parser, new[]{ "Authority", "Block", "Evidence", "Validator" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Consensus.V1.MsgUpdateParamsResponse), global::Cosmos.Consensus.V1.MsgUpdateParamsResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// MsgUpdateParams is the Msg/UpdateParams request type.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MsgUpdateParams : pb::IMessage<MsgUpdateParams>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgUpdateParams> _parser = new pb::MessageParser<MsgUpdateParams>(() => new MsgUpdateParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgUpdateParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Consensus.V1.TxReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParams(MsgUpdateParams other) : this() {
      authority_ = other.authority_;
      block_ = other.block_ != null ? other.block_.Clone() : null;
      evidence_ = other.evidence_ != null ? other.evidence_.Clone() : null;
      validator_ = other.validator_ != null ? other.validator_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParams Clone() {
      return new MsgUpdateParams(this);
    }

    /// <summary>Field number for the "authority" field.</summary>
    public const int AuthorityFieldNumber = 1;
    private string authority_ = "";
    /// <summary>
    /// authority is the address that controls the module (defaults to x/gov unless overwritten).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Authority {
      get { return authority_; }
      set {
        authority_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "block" field.</summary>
    public const int BlockFieldNumber = 2;
    private global::Tendermint.Types.BlockParams block_;
    /// <summary>
    /// params defines the x/consensus parameters to update.
    /// VersionsParams is not included in this Msg because it is tracked
    /// separarately in x/upgrade.
    ///
    /// NOTE: All parameters must be supplied.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.BlockParams Block {
      get { return block_; }
      set {
        block_ = value;
      }
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 3;
    private global::Tendermint.Types.EvidenceParams evidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.EvidenceParams Evidence {
      get { return evidence_; }
      set {
        evidence_ = value;
      }
    }

    /// <summary>Field number for the "validator" field.</summary>
    public const int ValidatorFieldNumber = 4;
    private global::Tendermint.Types.ValidatorParams validator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.ValidatorParams Validator {
      get { return validator_; }
      set {
        validator_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgUpdateParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgUpdateParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Authority != other.Authority) return false;
      if (!object.Equals(Block, other.Block)) return false;
      if (!object.Equals(Evidence, other.Evidence)) return false;
      if (!object.Equals(Validator, other.Validator)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Authority.Length != 0) hash ^= Authority.GetHashCode();
      if (block_ != null) hash ^= Block.GetHashCode();
      if (evidence_ != null) hash ^= Evidence.GetHashCode();
      if (validator_ != null) hash ^= Validator.GetHashCode();
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
      if (Authority.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Authority);
      }
      if (block_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Block);
      }
      if (evidence_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Evidence);
      }
      if (validator_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Validator);
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
      if (Authority.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Authority);
      }
      if (block_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Block);
      }
      if (evidence_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Evidence);
      }
      if (validator_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Validator);
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
      if (Authority.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Authority);
      }
      if (block_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Block);
      }
      if (evidence_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Evidence);
      }
      if (validator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Validator);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgUpdateParams other) {
      if (other == null) {
        return;
      }
      if (other.Authority.Length != 0) {
        Authority = other.Authority;
      }
      if (other.block_ != null) {
        if (block_ == null) {
          Block = new global::Tendermint.Types.BlockParams();
        }
        Block.MergeFrom(other.Block);
      }
      if (other.evidence_ != null) {
        if (evidence_ == null) {
          Evidence = new global::Tendermint.Types.EvidenceParams();
        }
        Evidence.MergeFrom(other.Evidence);
      }
      if (other.validator_ != null) {
        if (validator_ == null) {
          Validator = new global::Tendermint.Types.ValidatorParams();
        }
        Validator.MergeFrom(other.Validator);
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
            Authority = input.ReadString();
            break;
          }
          case 18: {
            if (block_ == null) {
              Block = new global::Tendermint.Types.BlockParams();
            }
            input.ReadMessage(Block);
            break;
          }
          case 26: {
            if (evidence_ == null) {
              Evidence = new global::Tendermint.Types.EvidenceParams();
            }
            input.ReadMessage(Evidence);
            break;
          }
          case 34: {
            if (validator_ == null) {
              Validator = new global::Tendermint.Types.ValidatorParams();
            }
            input.ReadMessage(Validator);
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
            Authority = input.ReadString();
            break;
          }
          case 18: {
            if (block_ == null) {
              Block = new global::Tendermint.Types.BlockParams();
            }
            input.ReadMessage(Block);
            break;
          }
          case 26: {
            if (evidence_ == null) {
              Evidence = new global::Tendermint.Types.EvidenceParams();
            }
            input.ReadMessage(Evidence);
            break;
          }
          case 34: {
            if (validator_ == null) {
              Validator = new global::Tendermint.Types.ValidatorParams();
            }
            input.ReadMessage(Validator);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgUpdateParamsResponse defines the response structure for executing a
  /// MsgUpdateParams message.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MsgUpdateParamsResponse : pb::IMessage<MsgUpdateParamsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgUpdateParamsResponse> _parser = new pb::MessageParser<MsgUpdateParamsResponse>(() => new MsgUpdateParamsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgUpdateParamsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Consensus.V1.TxReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParamsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParamsResponse(MsgUpdateParamsResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgUpdateParamsResponse Clone() {
      return new MsgUpdateParamsResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgUpdateParamsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgUpdateParamsResponse other) {
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
    public void MergeFrom(MsgUpdateParamsResponse other) {
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

  #endregion

}

#endregion Designer generated code
