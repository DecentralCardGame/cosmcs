// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/store/v1beta1/listening.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Store.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/store/v1beta1/listening.proto</summary>
  public static partial class ListeningReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/store/v1beta1/listening.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListeningReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRjb3Ntb3Mvc3RvcmUvdjFiZXRhMS9saXN0ZW5pbmcucHJvdG8SFGNvc21v",
            "cy5zdG9yZS52MWJldGExGht0ZW5kZXJtaW50L2FiY2kvdHlwZXMucHJvdG8i",
            "agoLU3RvcmVLVlBhaXISGwoJc3RvcmVfa2V5GAEgASgJUghzdG9yZUtleRIW",
            "CgZkZWxldGUYAiABKAhSBmRlbGV0ZRIQCgNrZXkYAyABKAxSA2tleRIUCgV2",
            "YWx1ZRgEIAEoDFIFdmFsdWUitAIKDUJsb2NrTWV0YWRhdGESSAoPcmVzcG9u",
            "c2VfY29tbWl0GAYgASgLMh8udGVuZGVybWludC5hYmNpLlJlc3BvbnNlQ29t",
            "bWl0Ug5yZXNwb25zZUNvbW1pdBJbChZyZXF1ZXN0X2ZpbmFsaXplX2Jsb2Nr",
            "GAcgASgLMiUudGVuZGVybWludC5hYmNpLlJlcXVlc3RGaW5hbGl6ZUJsb2Nr",
            "UhRyZXF1ZXN0RmluYWxpemVCbG9jaxJeChdyZXNwb25zZV9maW5hbGl6ZV9i",
            "bG9jaxgIIAEoCzImLnRlbmRlcm1pbnQuYWJjaS5SZXNwb25zZUZpbmFsaXpl",
            "QmxvY2tSFXJlc3BvbnNlRmluYWxpemVCbG9ja0oECAEQAkoECAIQA0oECAMQ",
            "BEoECAQQBUoECAUQBkK2AQoYY29tLmNvc21vcy5zdG9yZS52MWJldGExQg5M",
            "aXN0ZW5pbmdQcm90b1ABWhhjb3Ntb3NzZGsuaW8vc3RvcmUvdHlwZXOiAgND",
            "U1iqAhRDb3Ntb3MuU3RvcmUuVjFiZXRhMcoCFENvc21vc1xTdG9yZVxWMWJl",
            "dGEx4gIgQ29zbW9zXFN0b3JlXFYxYmV0YTFcR1BCTWV0YWRhdGHqAhZDb3Nt",
            "b3M6OlN0b3JlOjpWMWJldGExYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tendermint.Abci.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Store.V1beta1.StoreKVPair), global::Cosmos.Store.V1beta1.StoreKVPair.Parser, new[]{ "StoreKey", "Delete", "Key", "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Store.V1beta1.BlockMetadata), global::Cosmos.Store.V1beta1.BlockMetadata.Parser, new[]{ "ResponseCommit", "RequestFinalizeBlock", "ResponseFinalizeBlock" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// StoreKVPair is a KVStore KVPair used for listening to state changes (Sets and Deletes)
  /// It optionally includes the StoreKey for the originating KVStore and a Boolean flag to distinguish between Sets and
  /// Deletes
  ///
  /// Since: cosmos-sdk 0.43
  /// </summary>
  public sealed partial class StoreKVPair : pb::IMessage<StoreKVPair>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StoreKVPair> _parser = new pb::MessageParser<StoreKVPair>(() => new StoreKVPair());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StoreKVPair> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Store.V1beta1.ListeningReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreKVPair() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreKVPair(StoreKVPair other) : this() {
      storeKey_ = other.storeKey_;
      delete_ = other.delete_;
      key_ = other.key_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoreKVPair Clone() {
      return new StoreKVPair(this);
    }

    /// <summary>Field number for the "store_key" field.</summary>
    public const int StoreKeyFieldNumber = 1;
    private string storeKey_ = "";
    /// <summary>
    /// the store key for the KVStore this pair originates from
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StoreKey {
      get { return storeKey_; }
      set {
        storeKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delete" field.</summary>
    public const int DeleteFieldNumber = 2;
    private bool delete_;
    /// <summary>
    /// true indicates a delete operation, false indicates a set operation
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Delete {
      get { return delete_; }
      set {
        delete_ = value;
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 3;
    private pb::ByteString key_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 4;
    private pb::ByteString value_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StoreKVPair);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StoreKVPair other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StoreKey != other.StoreKey) return false;
      if (Delete != other.Delete) return false;
      if (Key != other.Key) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StoreKey.Length != 0) hash ^= StoreKey.GetHashCode();
      if (Delete != false) hash ^= Delete.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
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
      if (StoreKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StoreKey);
      }
      if (Delete != false) {
        output.WriteRawTag(16);
        output.WriteBool(Delete);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Key);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Value);
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
      if (StoreKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StoreKey);
      }
      if (Delete != false) {
        output.WriteRawTag(16);
        output.WriteBool(Delete);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Key);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Value);
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
      if (StoreKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StoreKey);
      }
      if (Delete != false) {
        size += 1 + 1;
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Key);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StoreKVPair other) {
      if (other == null) {
        return;
      }
      if (other.StoreKey.Length != 0) {
        StoreKey = other.StoreKey;
      }
      if (other.Delete != false) {
        Delete = other.Delete;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
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
            StoreKey = input.ReadString();
            break;
          }
          case 16: {
            Delete = input.ReadBool();
            break;
          }
          case 26: {
            Key = input.ReadBytes();
            break;
          }
          case 34: {
            Value = input.ReadBytes();
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
            StoreKey = input.ReadString();
            break;
          }
          case 16: {
            Delete = input.ReadBool();
            break;
          }
          case 26: {
            Key = input.ReadBytes();
            break;
          }
          case 34: {
            Value = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// BlockMetadata contains all the abci event data of a block
  /// the file streamer dump them into files together with the state changes.
  /// </summary>
  public sealed partial class BlockMetadata : pb::IMessage<BlockMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlockMetadata> _parser = new pb::MessageParser<BlockMetadata>(() => new BlockMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlockMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Store.V1beta1.ListeningReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlockMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlockMetadata(BlockMetadata other) : this() {
      responseCommit_ = other.responseCommit_ != null ? other.responseCommit_.Clone() : null;
      requestFinalizeBlock_ = other.requestFinalizeBlock_ != null ? other.requestFinalizeBlock_.Clone() : null;
      responseFinalizeBlock_ = other.responseFinalizeBlock_ != null ? other.responseFinalizeBlock_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlockMetadata Clone() {
      return new BlockMetadata(this);
    }

    /// <summary>Field number for the "response_commit" field.</summary>
    public const int ResponseCommitFieldNumber = 6;
    private global::Tendermint.Abci.ResponseCommit responseCommit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Abci.ResponseCommit ResponseCommit {
      get { return responseCommit_; }
      set {
        responseCommit_ = value;
      }
    }

    /// <summary>Field number for the "request_finalize_block" field.</summary>
    public const int RequestFinalizeBlockFieldNumber = 7;
    private global::Tendermint.Abci.RequestFinalizeBlock requestFinalizeBlock_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Abci.RequestFinalizeBlock RequestFinalizeBlock {
      get { return requestFinalizeBlock_; }
      set {
        requestFinalizeBlock_ = value;
      }
    }

    /// <summary>Field number for the "response_finalize_block" field.</summary>
    public const int ResponseFinalizeBlockFieldNumber = 8;
    private global::Tendermint.Abci.ResponseFinalizeBlock responseFinalizeBlock_;
    /// <summary>
    /// TODO: should we renumber this?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Abci.ResponseFinalizeBlock ResponseFinalizeBlock {
      get { return responseFinalizeBlock_; }
      set {
        responseFinalizeBlock_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlockMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlockMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ResponseCommit, other.ResponseCommit)) return false;
      if (!object.Equals(RequestFinalizeBlock, other.RequestFinalizeBlock)) return false;
      if (!object.Equals(ResponseFinalizeBlock, other.ResponseFinalizeBlock)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (responseCommit_ != null) hash ^= ResponseCommit.GetHashCode();
      if (requestFinalizeBlock_ != null) hash ^= RequestFinalizeBlock.GetHashCode();
      if (responseFinalizeBlock_ != null) hash ^= ResponseFinalizeBlock.GetHashCode();
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
      if (responseCommit_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ResponseCommit);
      }
      if (requestFinalizeBlock_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RequestFinalizeBlock);
      }
      if (responseFinalizeBlock_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ResponseFinalizeBlock);
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
      if (responseCommit_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ResponseCommit);
      }
      if (requestFinalizeBlock_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RequestFinalizeBlock);
      }
      if (responseFinalizeBlock_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ResponseFinalizeBlock);
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
      if (responseCommit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseCommit);
      }
      if (requestFinalizeBlock_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RequestFinalizeBlock);
      }
      if (responseFinalizeBlock_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResponseFinalizeBlock);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlockMetadata other) {
      if (other == null) {
        return;
      }
      if (other.responseCommit_ != null) {
        if (responseCommit_ == null) {
          ResponseCommit = new global::Tendermint.Abci.ResponseCommit();
        }
        ResponseCommit.MergeFrom(other.ResponseCommit);
      }
      if (other.requestFinalizeBlock_ != null) {
        if (requestFinalizeBlock_ == null) {
          RequestFinalizeBlock = new global::Tendermint.Abci.RequestFinalizeBlock();
        }
        RequestFinalizeBlock.MergeFrom(other.RequestFinalizeBlock);
      }
      if (other.responseFinalizeBlock_ != null) {
        if (responseFinalizeBlock_ == null) {
          ResponseFinalizeBlock = new global::Tendermint.Abci.ResponseFinalizeBlock();
        }
        ResponseFinalizeBlock.MergeFrom(other.ResponseFinalizeBlock);
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
          case 50: {
            if (responseCommit_ == null) {
              ResponseCommit = new global::Tendermint.Abci.ResponseCommit();
            }
            input.ReadMessage(ResponseCommit);
            break;
          }
          case 58: {
            if (requestFinalizeBlock_ == null) {
              RequestFinalizeBlock = new global::Tendermint.Abci.RequestFinalizeBlock();
            }
            input.ReadMessage(RequestFinalizeBlock);
            break;
          }
          case 66: {
            if (responseFinalizeBlock_ == null) {
              ResponseFinalizeBlock = new global::Tendermint.Abci.ResponseFinalizeBlock();
            }
            input.ReadMessage(ResponseFinalizeBlock);
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
          case 50: {
            if (responseCommit_ == null) {
              ResponseCommit = new global::Tendermint.Abci.ResponseCommit();
            }
            input.ReadMessage(ResponseCommit);
            break;
          }
          case 58: {
            if (requestFinalizeBlock_ == null) {
              RequestFinalizeBlock = new global::Tendermint.Abci.RequestFinalizeBlock();
            }
            input.ReadMessage(RequestFinalizeBlock);
            break;
          }
          case 66: {
            if (responseFinalizeBlock_ == null) {
              ResponseFinalizeBlock = new global::Tendermint.Abci.ResponseFinalizeBlock();
            }
            input.ReadMessage(ResponseFinalizeBlock);
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
