// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/staking/v1beta1/genesis.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Staking.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/staking/v1beta1/genesis.proto</summary>
  public static partial class GenesisReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/staking/v1beta1/genesis.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenesisReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRjb3Ntb3Mvc3Rha2luZy92MWJldGExL2dlbmVzaXMucHJvdG8SFmNvc21v",
            "cy5zdGFraW5nLnYxYmV0YTEaFGdvZ29wcm90by9nb2dvLnByb3RvGiRjb3Nt",
            "b3Mvc3Rha2luZy92MWJldGExL3N0YWtpbmcucHJvdG8aGWNvc21vc19wcm90",
            "by9jb3Ntb3MucHJvdG8aEWFtaW5vL2FtaW5vLnByb3RvIpcFCgxHZW5lc2lz",
            "U3RhdGUSQQoGcGFyYW1zGAEgASgLMh4uY29zbW9zLnN0YWtpbmcudjFiZXRh",
            "MS5QYXJhbXNCCcjeHwCo57AqAVIGcGFyYW1zEloKEGxhc3RfdG90YWxfcG93",
            "ZXIYAiABKAxCMMjeHwDa3h8VY29zbW9zc2RrLmlvL21hdGguSW500rQtCmNv",
            "c21vcy5JbnSo57AqAVIObGFzdFRvdGFsUG93ZXISaQoVbGFzdF92YWxpZGF0",
            "b3JfcG93ZXJzGAMgAygLMiouY29zbW9zLnN0YWtpbmcudjFiZXRhMS5MYXN0",
            "VmFsaWRhdG9yUG93ZXJCCcjeHwCo57AqAVITbGFzdFZhbGlkYXRvclBvd2Vy",
            "cxJMCgp2YWxpZGF0b3JzGAQgAygLMiEuY29zbW9zLnN0YWtpbmcudjFiZXRh",
            "MS5WYWxpZGF0b3JCCcjeHwCo57AqAVIKdmFsaWRhdG9ycxJPCgtkZWxlZ2F0",
            "aW9ucxgFIAMoCzIiLmNvc21vcy5zdGFraW5nLnYxYmV0YTEuRGVsZWdhdGlv",
            "bkIJyN4fAKjnsCoBUgtkZWxlZ2F0aW9ucxJrChV1bmJvbmRpbmdfZGVsZWdh",
            "dGlvbnMYBiADKAsyKy5jb3Ntb3Muc3Rha2luZy52MWJldGExLlVuYm9uZGlu",
            "Z0RlbGVnYXRpb25CCcjeHwCo57AqAVIUdW5ib25kaW5nRGVsZWdhdGlvbnMS",
            "VQoNcmVkZWxlZ2F0aW9ucxgHIAMoCzIkLmNvc21vcy5zdGFraW5nLnYxYmV0",
            "YTEuUmVkZWxlZ2F0aW9uQgnI3h8AqOewKgFSDXJlZGVsZWdhdGlvbnMSGgoI",
            "ZXhwb3J0ZWQYCCABKAhSCGV4cG9ydGVkImgKEkxhc3RWYWxpZGF0b3JQb3dl",
            "chIyCgdhZGRyZXNzGAEgASgJQhjStC0UY29zbW9zLkFkZHJlc3NTdHJpbmdS",
            "B2FkZHJlc3MSFAoFcG93ZXIYAiABKANSBXBvd2VyOgiIoB8A6KAfAELoAQoa",
            "Y29tLmNvc21vcy5zdGFraW5nLnYxYmV0YTFCDEdlbmVzaXNQcm90b1ABWkJn",
            "aXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL2Nvc21vcy9zdGFraW5nL3Yx",
            "YmV0YTE7c3Rha2luZ3YxYmV0YTGiAgNDU1iqAhZDb3Ntb3MuU3Rha2luZy5W",
            "MWJldGExygIWQ29zbW9zXFN0YWtpbmdcVjFiZXRhMeICIkNvc21vc1xTdGFr",
            "aW5nXFYxYmV0YTFcR1BCTWV0YWRhdGHqAhhDb3Ntb3M6OlN0YWtpbmc6OlYx",
            "YmV0YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Cosmos.Staking.V1beta1.StakingReflection.Descriptor, global::CosmosProto.CosmosReflection.Descriptor, global::Amino.AminoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Staking.V1beta1.GenesisState), global::Cosmos.Staking.V1beta1.GenesisState.Parser, new[]{ "Params", "LastTotalPower", "LastValidatorPowers", "Validators", "Delegations", "UnbondingDelegations", "Redelegations", "Exported" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Staking.V1beta1.LastValidatorPower), global::Cosmos.Staking.V1beta1.LastValidatorPower.Parser, new[]{ "Address", "Power" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// GenesisState defines the staking module's genesis state.
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
      get { return global::Cosmos.Staking.V1beta1.GenesisReflection.Descriptor.MessageTypes[0]; }
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
      params_ = other.params_ != null ? other.params_.Clone() : null;
      lastTotalPower_ = other.lastTotalPower_;
      lastValidatorPowers_ = other.lastValidatorPowers_.Clone();
      validators_ = other.validators_.Clone();
      delegations_ = other.delegations_.Clone();
      unbondingDelegations_ = other.unbondingDelegations_.Clone();
      redelegations_ = other.redelegations_.Clone();
      exported_ = other.exported_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState Clone() {
      return new GenesisState(this);
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 1;
    private global::Cosmos.Staking.V1beta1.Params params_;
    /// <summary>
    /// params defines all the parameters of related to deposit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Staking.V1beta1.Params Params {
      get { return params_; }
      set {
        params_ = value;
      }
    }

    /// <summary>Field number for the "last_total_power" field.</summary>
    public const int LastTotalPowerFieldNumber = 2;
    private pb::ByteString lastTotalPower_ = pb::ByteString.Empty;
    /// <summary>
    /// last_total_power tracks the total amounts of bonded tokens recorded during
    /// the previous end block.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString LastTotalPower {
      get { return lastTotalPower_; }
      set {
        lastTotalPower_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_validator_powers" field.</summary>
    public const int LastValidatorPowersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cosmos.Staking.V1beta1.LastValidatorPower> _repeated_lastValidatorPowers_codec
        = pb::FieldCodec.ForMessage(26, global::Cosmos.Staking.V1beta1.LastValidatorPower.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Staking.V1beta1.LastValidatorPower> lastValidatorPowers_ = new pbc::RepeatedField<global::Cosmos.Staking.V1beta1.LastValidatorPower>();
    /// <summary>
    /// last_validator_powers is a special index that provides a historical list
    /// of the last-block's bonded validators.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Staking.V1beta1.LastValidatorPower> LastValidatorPowers {
      get { return lastValidatorPowers_; }
    }

    /// <summary>Field number for the "validators" field.</summary>
    public const int ValidatorsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Cosmos.Staking.V1beta1.Validator> _repeated_validators_codec
        = pb::FieldCodec.ForMessage(34, global::Cosmos.Staking.V1beta1.Validator.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Validator> validators_ = new pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Validator>();
    /// <summary>
    /// validators defines the validator set at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Validator> Validators {
      get { return validators_; }
    }

    /// <summary>Field number for the "delegations" field.</summary>
    public const int DelegationsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Cosmos.Staking.V1beta1.Delegation> _repeated_delegations_codec
        = pb::FieldCodec.ForMessage(42, global::Cosmos.Staking.V1beta1.Delegation.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Delegation> delegations_ = new pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Delegation>();
    /// <summary>
    /// delegations defines the delegations active at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Delegation> Delegations {
      get { return delegations_; }
    }

    /// <summary>Field number for the "unbonding_delegations" field.</summary>
    public const int UnbondingDelegationsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Cosmos.Staking.V1beta1.UnbondingDelegation> _repeated_unbondingDelegations_codec
        = pb::FieldCodec.ForMessage(50, global::Cosmos.Staking.V1beta1.UnbondingDelegation.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Staking.V1beta1.UnbondingDelegation> unbondingDelegations_ = new pbc::RepeatedField<global::Cosmos.Staking.V1beta1.UnbondingDelegation>();
    /// <summary>
    /// unbonding_delegations defines the unbonding delegations active at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Staking.V1beta1.UnbondingDelegation> UnbondingDelegations {
      get { return unbondingDelegations_; }
    }

    /// <summary>Field number for the "redelegations" field.</summary>
    public const int RedelegationsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Cosmos.Staking.V1beta1.Redelegation> _repeated_redelegations_codec
        = pb::FieldCodec.ForMessage(58, global::Cosmos.Staking.V1beta1.Redelegation.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Redelegation> redelegations_ = new pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Redelegation>();
    /// <summary>
    /// redelegations defines the redelegations active at genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Staking.V1beta1.Redelegation> Redelegations {
      get { return redelegations_; }
    }

    /// <summary>Field number for the "exported" field.</summary>
    public const int ExportedFieldNumber = 8;
    private bool exported_;
    /// <summary>
    /// exported defines a bool to identify whether the chain dealing with exported or initialized genesis.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Exported {
      get { return exported_; }
      set {
        exported_ = value;
      }
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
      if (!object.Equals(Params, other.Params)) return false;
      if (LastTotalPower != other.LastTotalPower) return false;
      if(!lastValidatorPowers_.Equals(other.lastValidatorPowers_)) return false;
      if(!validators_.Equals(other.validators_)) return false;
      if(!delegations_.Equals(other.delegations_)) return false;
      if(!unbondingDelegations_.Equals(other.unbondingDelegations_)) return false;
      if(!redelegations_.Equals(other.redelegations_)) return false;
      if (Exported != other.Exported) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (params_ != null) hash ^= Params.GetHashCode();
      if (LastTotalPower.Length != 0) hash ^= LastTotalPower.GetHashCode();
      hash ^= lastValidatorPowers_.GetHashCode();
      hash ^= validators_.GetHashCode();
      hash ^= delegations_.GetHashCode();
      hash ^= unbondingDelegations_.GetHashCode();
      hash ^= redelegations_.GetHashCode();
      if (Exported != false) hash ^= Exported.GetHashCode();
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
      if (params_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Params);
      }
      if (LastTotalPower.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(LastTotalPower);
      }
      lastValidatorPowers_.WriteTo(output, _repeated_lastValidatorPowers_codec);
      validators_.WriteTo(output, _repeated_validators_codec);
      delegations_.WriteTo(output, _repeated_delegations_codec);
      unbondingDelegations_.WriteTo(output, _repeated_unbondingDelegations_codec);
      redelegations_.WriteTo(output, _repeated_redelegations_codec);
      if (Exported != false) {
        output.WriteRawTag(64);
        output.WriteBool(Exported);
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
      if (params_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Params);
      }
      if (LastTotalPower.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(LastTotalPower);
      }
      lastValidatorPowers_.WriteTo(ref output, _repeated_lastValidatorPowers_codec);
      validators_.WriteTo(ref output, _repeated_validators_codec);
      delegations_.WriteTo(ref output, _repeated_delegations_codec);
      unbondingDelegations_.WriteTo(ref output, _repeated_unbondingDelegations_codec);
      redelegations_.WriteTo(ref output, _repeated_redelegations_codec);
      if (Exported != false) {
        output.WriteRawTag(64);
        output.WriteBool(Exported);
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
      if (params_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Params);
      }
      if (LastTotalPower.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(LastTotalPower);
      }
      size += lastValidatorPowers_.CalculateSize(_repeated_lastValidatorPowers_codec);
      size += validators_.CalculateSize(_repeated_validators_codec);
      size += delegations_.CalculateSize(_repeated_delegations_codec);
      size += unbondingDelegations_.CalculateSize(_repeated_unbondingDelegations_codec);
      size += redelegations_.CalculateSize(_repeated_redelegations_codec);
      if (Exported != false) {
        size += 1 + 1;
      }
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
      if (other.params_ != null) {
        if (params_ == null) {
          Params = new global::Cosmos.Staking.V1beta1.Params();
        }
        Params.MergeFrom(other.Params);
      }
      if (other.LastTotalPower.Length != 0) {
        LastTotalPower = other.LastTotalPower;
      }
      lastValidatorPowers_.Add(other.lastValidatorPowers_);
      validators_.Add(other.validators_);
      delegations_.Add(other.delegations_);
      unbondingDelegations_.Add(other.unbondingDelegations_);
      redelegations_.Add(other.redelegations_);
      if (other.Exported != false) {
        Exported = other.Exported;
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
          case 10: {
            if (params_ == null) {
              Params = new global::Cosmos.Staking.V1beta1.Params();
            }
            input.ReadMessage(Params);
            break;
          }
          case 18: {
            LastTotalPower = input.ReadBytes();
            break;
          }
          case 26: {
            lastValidatorPowers_.AddEntriesFrom(input, _repeated_lastValidatorPowers_codec);
            break;
          }
          case 34: {
            validators_.AddEntriesFrom(input, _repeated_validators_codec);
            break;
          }
          case 42: {
            delegations_.AddEntriesFrom(input, _repeated_delegations_codec);
            break;
          }
          case 50: {
            unbondingDelegations_.AddEntriesFrom(input, _repeated_unbondingDelegations_codec);
            break;
          }
          case 58: {
            redelegations_.AddEntriesFrom(input, _repeated_redelegations_codec);
            break;
          }
          case 64: {
            Exported = input.ReadBool();
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
          case 10: {
            if (params_ == null) {
              Params = new global::Cosmos.Staking.V1beta1.Params();
            }
            input.ReadMessage(Params);
            break;
          }
          case 18: {
            LastTotalPower = input.ReadBytes();
            break;
          }
          case 26: {
            lastValidatorPowers_.AddEntriesFrom(ref input, _repeated_lastValidatorPowers_codec);
            break;
          }
          case 34: {
            validators_.AddEntriesFrom(ref input, _repeated_validators_codec);
            break;
          }
          case 42: {
            delegations_.AddEntriesFrom(ref input, _repeated_delegations_codec);
            break;
          }
          case 50: {
            unbondingDelegations_.AddEntriesFrom(ref input, _repeated_unbondingDelegations_codec);
            break;
          }
          case 58: {
            redelegations_.AddEntriesFrom(ref input, _repeated_redelegations_codec);
            break;
          }
          case 64: {
            Exported = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// LastValidatorPower required for validator set update logic.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LastValidatorPower : pb::IMessage<LastValidatorPower>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LastValidatorPower> _parser = new pb::MessageParser<LastValidatorPower>(() => new LastValidatorPower());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LastValidatorPower> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Staking.V1beta1.GenesisReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LastValidatorPower() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LastValidatorPower(LastValidatorPower other) : this() {
      address_ = other.address_;
      power_ = other.power_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LastValidatorPower Clone() {
      return new LastValidatorPower(this);
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 1;
    private string address_ = "";
    /// <summary>
    /// address is the address of the validator.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "power" field.</summary>
    public const int PowerFieldNumber = 2;
    private long power_;
    /// <summary>
    /// power defines the power of the validator.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Power {
      get { return power_; }
      set {
        power_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LastValidatorPower);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LastValidatorPower other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Address != other.Address) return false;
      if (Power != other.Power) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (Power != 0L) hash ^= Power.GetHashCode();
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Power != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Power);
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Power != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Power);
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
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Power != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Power);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LastValidatorPower other) {
      if (other == null) {
        return;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.Power != 0L) {
        Power = other.Power;
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
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 16: {
            Power = input.ReadInt64();
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
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 16: {
            Power = input.ReadInt64();
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
