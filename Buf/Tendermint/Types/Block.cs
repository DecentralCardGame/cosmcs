// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tendermint/types/block.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tendermint.Types {

  /// <summary>Holder for reflection information generated from tendermint/types/block.proto</summary>
  public static partial class BlockReflection {

    #region Descriptor
    /// <summary>File descriptor for tendermint/types/block.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlockReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chx0ZW5kZXJtaW50L3R5cGVzL2Jsb2NrLnByb3RvEhB0ZW5kZXJtaW50LnR5",
            "cGVzGhRnb2dvcHJvdG8vZ29nby5wcm90bxocdGVuZGVybWludC90eXBlcy90",
            "eXBlcy5wcm90bxofdGVuZGVybWludC90eXBlcy9ldmlkZW5jZS5wcm90byLu",
            "AQoFQmxvY2sSNgoGaGVhZGVyGAEgASgLMhgudGVuZGVybWludC50eXBlcy5I",
            "ZWFkZXJCBMjeHwBSBmhlYWRlchIwCgRkYXRhGAIgASgLMhYudGVuZGVybWlu",
            "dC50eXBlcy5EYXRhQgTI3h8AUgRkYXRhEkAKCGV2aWRlbmNlGAMgASgLMh4u",
            "dGVuZGVybWludC50eXBlcy5FdmlkZW5jZUxpc3RCBMjeHwBSCGV2aWRlbmNl",
            "EjkKC2xhc3RfY29tbWl0GAQgASgLMhgudGVuZGVybWludC50eXBlcy5Db21t",
            "aXRSCmxhc3RDb21taXRCuAEKFGNvbS50ZW5kZXJtaW50LnR5cGVzQgpCbG9j",
            "a1Byb3RvUAFaM2dpdGh1Yi5jb20vY29tZXRiZnQvY29tZXRiZnQvcHJvdG8v",
            "dGVuZGVybWludC90eXBlc6ICA1RUWKoCEFRlbmRlcm1pbnQuVHlwZXPKAhBU",
            "ZW5kZXJtaW50XFR5cGVz4gIcVGVuZGVybWludFxUeXBlc1xHUEJNZXRhZGF0",
            "YeoCEVRlbmRlcm1pbnQ6OlR5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Tendermint.Types.TypesReflection.Descriptor, global::Tendermint.Types.EvidenceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tendermint.Types.Block), global::Tendermint.Types.Block.Parser, new[]{ "Header", "Data", "Evidence", "LastCommit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Block : pb::IMessage<Block>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Block> _parser = new pb::MessageParser<Block>(() => new Block());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Block> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tendermint.Types.BlockReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Block() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Block(Block other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      data_ = other.data_ != null ? other.data_.Clone() : null;
      evidence_ = other.evidence_ != null ? other.evidence_.Clone() : null;
      lastCommit_ = other.lastCommit_ != null ? other.lastCommit_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Block Clone() {
      return new Block(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Tendermint.Types.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 2;
    private global::Tendermint.Types.Data data_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.Data Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    /// <summary>Field number for the "evidence" field.</summary>
    public const int EvidenceFieldNumber = 3;
    private global::Tendermint.Types.EvidenceList evidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.EvidenceList Evidence {
      get { return evidence_; }
      set {
        evidence_ = value;
      }
    }

    /// <summary>Field number for the "last_commit" field.</summary>
    public const int LastCommitFieldNumber = 4;
    private global::Tendermint.Types.Commit lastCommit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Tendermint.Types.Commit LastCommit {
      get { return lastCommit_; }
      set {
        lastCommit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Block);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Block other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (!object.Equals(Data, other.Data)) return false;
      if (!object.Equals(Evidence, other.Evidence)) return false;
      if (!object.Equals(LastCommit, other.LastCommit)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (data_ != null) hash ^= Data.GetHashCode();
      if (evidence_ != null) hash ^= Evidence.GetHashCode();
      if (lastCommit_ != null) hash ^= LastCommit.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (data_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Data);
      }
      if (evidence_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Evidence);
      }
      if (lastCommit_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LastCommit);
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (data_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Data);
      }
      if (evidence_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Evidence);
      }
      if (lastCommit_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LastCommit);
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
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (evidence_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Evidence);
      }
      if (lastCommit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastCommit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Block other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Tendermint.Types.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Tendermint.Types.Data();
        }
        Data.MergeFrom(other.Data);
      }
      if (other.evidence_ != null) {
        if (evidence_ == null) {
          Evidence = new global::Tendermint.Types.EvidenceList();
        }
        Evidence.MergeFrom(other.Evidence);
      }
      if (other.lastCommit_ != null) {
        if (lastCommit_ == null) {
          LastCommit = new global::Tendermint.Types.Commit();
        }
        LastCommit.MergeFrom(other.LastCommit);
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
            if (header_ == null) {
              Header = new global::Tendermint.Types.Header();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            if (data_ == null) {
              Data = new global::Tendermint.Types.Data();
            }
            input.ReadMessage(Data);
            break;
          }
          case 26: {
            if (evidence_ == null) {
              Evidence = new global::Tendermint.Types.EvidenceList();
            }
            input.ReadMessage(Evidence);
            break;
          }
          case 34: {
            if (lastCommit_ == null) {
              LastCommit = new global::Tendermint.Types.Commit();
            }
            input.ReadMessage(LastCommit);
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
            if (header_ == null) {
              Header = new global::Tendermint.Types.Header();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            if (data_ == null) {
              Data = new global::Tendermint.Types.Data();
            }
            input.ReadMessage(Data);
            break;
          }
          case 26: {
            if (evidence_ == null) {
              Evidence = new global::Tendermint.Types.EvidenceList();
            }
            input.ReadMessage(Evidence);
            break;
          }
          case 34: {
            if (lastCommit_ == null) {
              LastCommit = new global::Tendermint.Types.Commit();
            }
            input.ReadMessage(LastCommit);
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
