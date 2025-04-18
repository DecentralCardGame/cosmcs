// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/evidence/v1beta1/evidence.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Evidence.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/evidence/v1beta1/evidence.proto</summary>
  public static partial class EvidenceReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/evidence/v1beta1/evidence.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvidenceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZjb3Ntb3MvZXZpZGVuY2UvdjFiZXRhMS9ldmlkZW5jZS5wcm90bxIXY29z",
            "bW9zLmV2aWRlbmNlLnYxYmV0YTEaEWFtaW5vL2FtaW5vLnByb3RvGhRnb2dv",
            "cHJvdG8vZ29nby5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5w",
            "cm90bxoZY29zbW9zX3Byb3RvL2Nvc21vcy5wcm90byLoAQoMRXF1aXZvY2F0",
            "aW9uEhYKBmhlaWdodBgBIAEoA1IGaGVpZ2h0Ej0KBHRpbWUYAiABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wQg3I3h8AkN8fAajnsCoBUgR0aW1l",
            "EhQKBXBvd2VyGAMgASgDUgVwb3dlchJFChFjb25zZW5zdXNfYWRkcmVzcxgE",
            "IAEoCUIY0rQtFGNvc21vcy5BZGRyZXNzU3RyaW5nUhBjb25zZW5zdXNBZGRy",
            "ZXNzOiSIoB8A6KAfAIrnsCoXY29zbW9zLXNkay9FcXVpdm9jYXRpb25C9AEK",
            "G2NvbS5jb3Ntb3MuZXZpZGVuY2UudjFiZXRhMUINRXZpZGVuY2VQcm90b1AB",
            "WkRnaXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL2Nvc21vcy9ldmlkZW5j",
            "ZS92MWJldGExO2V2aWRlbmNldjFiZXRhMaICA0NFWKoCF0Nvc21vcy5Fdmlk",
            "ZW5jZS5WMWJldGExygIXQ29zbW9zXEV2aWRlbmNlXFYxYmV0YTHiAiNDb3Nt",
            "b3NcRXZpZGVuY2VcVjFiZXRhMVxHUEJNZXRhZGF0YeoCGUNvc21vczo6RXZp",
            "ZGVuY2U6OlYxYmV0YTGo4h4BYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Amino.AminoReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::CosmosProto.CosmosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Evidence.V1beta1.Equivocation), global::Cosmos.Evidence.V1beta1.Equivocation.Parser, new[]{ "Height", "Time", "Power", "ConsensusAddress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Equivocation implements the Evidence interface and defines evidence of double
  /// signing misbehavior.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Equivocation : pb::IMessage<Equivocation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Equivocation> _parser = new pb::MessageParser<Equivocation>(() => new Equivocation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Equivocation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Evidence.V1beta1.EvidenceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equivocation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equivocation(Equivocation other) : this() {
      height_ = other.height_;
      time_ = other.time_ != null ? other.time_.Clone() : null;
      power_ = other.power_;
      consensusAddress_ = other.consensusAddress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equivocation Clone() {
      return new Equivocation(this);
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 1;
    private long height_;
    /// <summary>
    /// height is the equivocation height.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp time_;
    /// <summary>
    /// time is the equivocation time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "power" field.</summary>
    public const int PowerFieldNumber = 3;
    private long power_;
    /// <summary>
    /// power is the equivocation validator power.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Power {
      get { return power_; }
      set {
        power_ = value;
      }
    }

    /// <summary>Field number for the "consensus_address" field.</summary>
    public const int ConsensusAddressFieldNumber = 4;
    private string consensusAddress_ = "";
    /// <summary>
    /// consensus_address is the equivocation validator consensus address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConsensusAddress {
      get { return consensusAddress_; }
      set {
        consensusAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Equivocation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Equivocation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Height != other.Height) return false;
      if (!object.Equals(Time, other.Time)) return false;
      if (Power != other.Power) return false;
      if (ConsensusAddress != other.ConsensusAddress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Height != 0L) hash ^= Height.GetHashCode();
      if (time_ != null) hash ^= Time.GetHashCode();
      if (Power != 0L) hash ^= Power.GetHashCode();
      if (ConsensusAddress.Length != 0) hash ^= ConsensusAddress.GetHashCode();
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
      if (Height != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Height);
      }
      if (time_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Time);
      }
      if (Power != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Power);
      }
      if (ConsensusAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ConsensusAddress);
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
      if (Height != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Height);
      }
      if (time_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Time);
      }
      if (Power != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Power);
      }
      if (ConsensusAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ConsensusAddress);
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
      if (Height != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Height);
      }
      if (time_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Time);
      }
      if (Power != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Power);
      }
      if (ConsensusAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConsensusAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Equivocation other) {
      if (other == null) {
        return;
      }
      if (other.Height != 0L) {
        Height = other.Height;
      }
      if (other.time_ != null) {
        if (time_ == null) {
          Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Time.MergeFrom(other.Time);
      }
      if (other.Power != 0L) {
        Power = other.Power;
      }
      if (other.ConsensusAddress.Length != 0) {
        ConsensusAddress = other.ConsensusAddress;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Height = input.ReadInt64();
            break;
          }
          case 18: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 24: {
            Power = input.ReadInt64();
            break;
          }
          case 34: {
            ConsensusAddress = input.ReadString();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Height = input.ReadInt64();
            break;
          }
          case 18: {
            if (time_ == null) {
              Time = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Time);
            break;
          }
          case 24: {
            Power = input.ReadInt64();
            break;
          }
          case 34: {
            ConsensusAddress = input.ReadString();
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
