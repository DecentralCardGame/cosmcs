// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/capability/v1beta1/genesis.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Capability.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/capability/v1beta1/genesis.proto</summary>
  public static partial class GenesisReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/capability/v1beta1/genesis.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenesisReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidjb3Ntb3MvY2FwYWJpbGl0eS92MWJldGExL2dlbmVzaXMucHJvdG8SGWNv",
            "c21vcy5jYXBhYmlsaXR5LnYxYmV0YTEaFGdvZ29wcm90by9nb2dvLnByb3Rv",
            "Gipjb3Ntb3MvY2FwYWJpbGl0eS92MWJldGExL2NhcGFiaWxpdHkucHJvdG8a",
            "EWFtaW5vL2FtaW5vLnByb3RvIoABCg1HZW5lc2lzT3duZXJzEhQKBWluZGV4",
            "GAEgASgEUgVpbmRleBJZCgxpbmRleF9vd25lcnMYAiABKAsyKy5jb3Ntb3Mu",
            "Y2FwYWJpbGl0eS52MWJldGExLkNhcGFiaWxpdHlPd25lcnNCCcjeHwCo57Aq",
            "AVILaW5kZXhPd25lcnMicQoMR2VuZXNpc1N0YXRlEhQKBWluZGV4GAEgASgE",
            "UgVpbmRleBJLCgZvd25lcnMYAiADKAsyKC5jb3Ntb3MuY2FwYWJpbGl0eS52",
            "MWJldGExLkdlbmVzaXNPd25lcnNCCcjeHwCo57AqAVIGb3duZXJzQv0BCh1j",
            "b20uY29zbW9zLmNhcGFiaWxpdHkudjFiZXRhMUIMR2VuZXNpc1Byb3RvUAFa",
            "SGdpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvY29zbW9zL2NhcGFiaWxp",
            "dHkvdjFiZXRhMTtjYXBhYmlsaXR5djFiZXRhMaICA0NDWKoCGUNvc21vcy5D",
            "YXBhYmlsaXR5LlYxYmV0YTHKAhlDb3Ntb3NcQ2FwYWJpbGl0eVxWMWJldGEx",
            "4gIlQ29zbW9zXENhcGFiaWxpdHlcVjFiZXRhMVxHUEJNZXRhZGF0YeoCG0Nv",
            "c21vczo6Q2FwYWJpbGl0eTo6VjFiZXRhMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Cosmos.Capability.V1beta1.CapabilityReflection.Descriptor, global::Amino.AminoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Capability.V1beta1.GenesisOwners), global::Cosmos.Capability.V1beta1.GenesisOwners.Parser, new[]{ "Index", "IndexOwners" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Capability.V1beta1.GenesisState), global::Cosmos.Capability.V1beta1.GenesisState.Parser, new[]{ "Index", "Owners" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// GenesisOwners defines the capability owners with their corresponding index.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GenesisOwners : pb::IMessage<GenesisOwners>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenesisOwners> _parser = new pb::MessageParser<GenesisOwners>(() => new GenesisOwners());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenesisOwners> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Capability.V1beta1.GenesisReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisOwners() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisOwners(GenesisOwners other) : this() {
      index_ = other.index_;
      indexOwners_ = other.indexOwners_ != null ? other.indexOwners_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisOwners Clone() {
      return new GenesisOwners(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private ulong index_;
    /// <summary>
    /// index is the index of the capability owner.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "index_owners" field.</summary>
    public const int IndexOwnersFieldNumber = 2;
    private global::Cosmos.Capability.V1beta1.CapabilityOwners indexOwners_;
    /// <summary>
    /// index_owners are the owners at the given index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Capability.V1beta1.CapabilityOwners IndexOwners {
      get { return indexOwners_; }
      set {
        indexOwners_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenesisOwners);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenesisOwners other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (!object.Equals(IndexOwners, other.IndexOwners)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0UL) hash ^= Index.GetHashCode();
      if (indexOwners_ != null) hash ^= IndexOwners.GetHashCode();
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
      if (Index != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Index);
      }
      if (indexOwners_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexOwners);
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
      if (Index != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Index);
      }
      if (indexOwners_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexOwners);
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
      if (Index != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Index);
      }
      if (indexOwners_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IndexOwners);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenesisOwners other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0UL) {
        Index = other.Index;
      }
      if (other.indexOwners_ != null) {
        if (indexOwners_ == null) {
          IndexOwners = new global::Cosmos.Capability.V1beta1.CapabilityOwners();
        }
        IndexOwners.MergeFrom(other.IndexOwners);
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
            Index = input.ReadUInt64();
            break;
          }
          case 18: {
            if (indexOwners_ == null) {
              IndexOwners = new global::Cosmos.Capability.V1beta1.CapabilityOwners();
            }
            input.ReadMessage(IndexOwners);
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
            Index = input.ReadUInt64();
            break;
          }
          case 18: {
            if (indexOwners_ == null) {
              IndexOwners = new global::Cosmos.Capability.V1beta1.CapabilityOwners();
            }
            input.ReadMessage(IndexOwners);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// GenesisState defines the capability module's genesis state.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GenesisState : pb::IMessage<GenesisState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenesisState> _parser = new pb::MessageParser<GenesisState>(() => new GenesisState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenesisState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Capability.V1beta1.GenesisReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState(GenesisState other) : this() {
      index_ = other.index_;
      owners_ = other.owners_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState Clone() {
      return new GenesisState(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private ulong index_;
    /// <summary>
    /// index is the capability global index.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "owners" field.</summary>
    public const int OwnersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cosmos.Capability.V1beta1.GenesisOwners> _repeated_owners_codec
        = pb::FieldCodec.ForMessage(18, global::Cosmos.Capability.V1beta1.GenesisOwners.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Capability.V1beta1.GenesisOwners> owners_ = new pbc::RepeatedField<global::Cosmos.Capability.V1beta1.GenesisOwners>();
    /// <summary>
    /// owners represents a map from index to owners of the capability index
    /// index key is string to allow amino marshalling.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Capability.V1beta1.GenesisOwners> Owners {
      get { return owners_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenesisState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenesisState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if(!owners_.Equals(other.owners_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0UL) hash ^= Index.GetHashCode();
      hash ^= owners_.GetHashCode();
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
      if (Index != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Index);
      }
      owners_.WriteTo(output, _repeated_owners_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Index != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Index);
      }
      owners_.WriteTo(ref output, _repeated_owners_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Index);
      }
      size += owners_.CalculateSize(_repeated_owners_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenesisState other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0UL) {
        Index = other.Index;
      }
      owners_.Add(other.owners_);
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
            Index = input.ReadUInt64();
            break;
          }
          case 18: {
            owners_.AddEntriesFrom(input, _repeated_owners_codec);
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
            Index = input.ReadUInt64();
            break;
          }
          case 18: {
            owners_.AddEntriesFrom(ref input, _repeated_owners_codec);
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
