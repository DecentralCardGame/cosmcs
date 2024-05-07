// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/group/v1/genesis.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Group.V1 {

  /// <summary>Holder for reflection information generated from cosmos/group/v1/genesis.proto</summary>
  public static partial class GenesisReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/group/v1/genesis.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenesisReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1jb3Ntb3MvZ3JvdXAvdjEvZ2VuZXNpcy5wcm90bxIPY29zbW9zLmdyb3Vw",
            "LnYxGhtjb3Ntb3MvZ3JvdXAvdjEvdHlwZXMucHJvdG8ingMKDEdlbmVzaXNT",
            "dGF0ZRIbCglncm91cF9zZXEYASABKARSCGdyb3VwU2VxEjIKBmdyb3VwcxgC",
            "IAMoCzIaLmNvc21vcy5ncm91cC52MS5Hcm91cEluZm9SBmdyb3VwcxJBCg1n",
            "cm91cF9tZW1iZXJzGAMgAygLMhwuY29zbW9zLmdyb3VwLnYxLkdyb3VwTWVt",
            "YmVyUgxncm91cE1lbWJlcnMSKAoQZ3JvdXBfcG9saWN5X3NlcRgEIAEoBFIO",
            "Z3JvdXBQb2xpY3lTZXESRwoOZ3JvdXBfcG9saWNpZXMYBSADKAsyIC5jb3Nt",
            "b3MuZ3JvdXAudjEuR3JvdXBQb2xpY3lJbmZvUg1ncm91cFBvbGljaWVzEiEK",
            "DHByb3Bvc2FsX3NlcRgGIAEoBFILcHJvcG9zYWxTZXESNwoJcHJvcG9zYWxz",
            "GAcgAygLMhkuY29zbW9zLmdyb3VwLnYxLlByb3Bvc2FsUglwcm9wb3NhbHMS",
            "KwoFdm90ZXMYCCADKAsyFS5jb3Ntb3MuZ3JvdXAudjEuVm90ZVIFdm90ZXNC",
            "twEKE2NvbS5jb3Ntb3MuZ3JvdXAudjFCDEdlbmVzaXNQcm90b1ABWjRnaXRo",
            "dWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL2Nvc21vcy9ncm91cC92MTtncm91",
            "cHYxogIDQ0dYqgIPQ29zbW9zLkdyb3VwLlYxygIPQ29zbW9zXEdyb3VwXFYx",
            "4gIbQ29zbW9zXEdyb3VwXFYxXEdQQk1ldGFkYXRh6gIRQ29zbW9zOjpHcm91",
            "cDo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cosmos.Group.V1.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Group.V1.GenesisState), global::Cosmos.Group.V1.GenesisState.Parser, new[]{ "GroupSeq", "Groups", "GroupMembers", "GroupPolicySeq", "GroupPolicies", "ProposalSeq", "Proposals", "Votes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// GenesisState defines the group module's genesis state.
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
      get { return global::Cosmos.Group.V1.GenesisReflection.Descriptor.MessageTypes[0]; }
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
      groupSeq_ = other.groupSeq_;
      groups_ = other.groups_.Clone();
      groupMembers_ = other.groupMembers_.Clone();
      groupPolicySeq_ = other.groupPolicySeq_;
      groupPolicies_ = other.groupPolicies_.Clone();
      proposalSeq_ = other.proposalSeq_;
      proposals_ = other.proposals_.Clone();
      votes_ = other.votes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState Clone() {
      return new GenesisState(this);
    }

    /// <summary>Field number for the "group_seq" field.</summary>
    public const int GroupSeqFieldNumber = 1;
    private ulong groupSeq_;
    /// <summary>
    /// group_seq is the group table orm.Sequence,
    /// it is used to get the next group ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong GroupSeq {
      get { return groupSeq_; }
      set {
        groupSeq_ = value;
      }
    }

    /// <summary>Field number for the "groups" field.</summary>
    public const int GroupsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cosmos.Group.V1.GroupInfo> _repeated_groups_codec
        = pb::FieldCodec.ForMessage(18, global::Cosmos.Group.V1.GroupInfo.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Group.V1.GroupInfo> groups_ = new pbc::RepeatedField<global::Cosmos.Group.V1.GroupInfo>();
    /// <summary>
    /// groups is the list of groups info.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Group.V1.GroupInfo> Groups {
      get { return groups_; }
    }

    /// <summary>Field number for the "group_members" field.</summary>
    public const int GroupMembersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cosmos.Group.V1.GroupMember> _repeated_groupMembers_codec
        = pb::FieldCodec.ForMessage(26, global::Cosmos.Group.V1.GroupMember.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Group.V1.GroupMember> groupMembers_ = new pbc::RepeatedField<global::Cosmos.Group.V1.GroupMember>();
    /// <summary>
    /// group_members is the list of groups members.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Group.V1.GroupMember> GroupMembers {
      get { return groupMembers_; }
    }

    /// <summary>Field number for the "group_policy_seq" field.</summary>
    public const int GroupPolicySeqFieldNumber = 4;
    private ulong groupPolicySeq_;
    /// <summary>
    /// group_policy_seq is the group policy table orm.Sequence,
    /// it is used to generate the next group policy account address.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong GroupPolicySeq {
      get { return groupPolicySeq_; }
      set {
        groupPolicySeq_ = value;
      }
    }

    /// <summary>Field number for the "group_policies" field.</summary>
    public const int GroupPoliciesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Cosmos.Group.V1.GroupPolicyInfo> _repeated_groupPolicies_codec
        = pb::FieldCodec.ForMessage(42, global::Cosmos.Group.V1.GroupPolicyInfo.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Group.V1.GroupPolicyInfo> groupPolicies_ = new pbc::RepeatedField<global::Cosmos.Group.V1.GroupPolicyInfo>();
    /// <summary>
    /// group_policies is the list of group policies info.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Group.V1.GroupPolicyInfo> GroupPolicies {
      get { return groupPolicies_; }
    }

    /// <summary>Field number for the "proposal_seq" field.</summary>
    public const int ProposalSeqFieldNumber = 6;
    private ulong proposalSeq_;
    /// <summary>
    /// proposal_seq is the proposal table orm.Sequence,
    /// it is used to get the next proposal ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ProposalSeq {
      get { return proposalSeq_; }
      set {
        proposalSeq_ = value;
      }
    }

    /// <summary>Field number for the "proposals" field.</summary>
    public const int ProposalsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Cosmos.Group.V1.Proposal> _repeated_proposals_codec
        = pb::FieldCodec.ForMessage(58, global::Cosmos.Group.V1.Proposal.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Group.V1.Proposal> proposals_ = new pbc::RepeatedField<global::Cosmos.Group.V1.Proposal>();
    /// <summary>
    /// proposals is the list of proposals.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Group.V1.Proposal> Proposals {
      get { return proposals_; }
    }

    /// <summary>Field number for the "votes" field.</summary>
    public const int VotesFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Cosmos.Group.V1.Vote> _repeated_votes_codec
        = pb::FieldCodec.ForMessage(66, global::Cosmos.Group.V1.Vote.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Group.V1.Vote> votes_ = new pbc::RepeatedField<global::Cosmos.Group.V1.Vote>();
    /// <summary>
    /// votes is the list of votes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Group.V1.Vote> Votes {
      get { return votes_; }
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
      if (GroupSeq != other.GroupSeq) return false;
      if(!groups_.Equals(other.groups_)) return false;
      if(!groupMembers_.Equals(other.groupMembers_)) return false;
      if (GroupPolicySeq != other.GroupPolicySeq) return false;
      if(!groupPolicies_.Equals(other.groupPolicies_)) return false;
      if (ProposalSeq != other.ProposalSeq) return false;
      if(!proposals_.Equals(other.proposals_)) return false;
      if(!votes_.Equals(other.votes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupSeq != 0UL) hash ^= GroupSeq.GetHashCode();
      hash ^= groups_.GetHashCode();
      hash ^= groupMembers_.GetHashCode();
      if (GroupPolicySeq != 0UL) hash ^= GroupPolicySeq.GetHashCode();
      hash ^= groupPolicies_.GetHashCode();
      if (ProposalSeq != 0UL) hash ^= ProposalSeq.GetHashCode();
      hash ^= proposals_.GetHashCode();
      hash ^= votes_.GetHashCode();
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
      if (GroupSeq != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(GroupSeq);
      }
      groups_.WriteTo(output, _repeated_groups_codec);
      groupMembers_.WriteTo(output, _repeated_groupMembers_codec);
      if (GroupPolicySeq != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(GroupPolicySeq);
      }
      groupPolicies_.WriteTo(output, _repeated_groupPolicies_codec);
      if (ProposalSeq != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ProposalSeq);
      }
      proposals_.WriteTo(output, _repeated_proposals_codec);
      votes_.WriteTo(output, _repeated_votes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GroupSeq != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(GroupSeq);
      }
      groups_.WriteTo(ref output, _repeated_groups_codec);
      groupMembers_.WriteTo(ref output, _repeated_groupMembers_codec);
      if (GroupPolicySeq != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(GroupPolicySeq);
      }
      groupPolicies_.WriteTo(ref output, _repeated_groupPolicies_codec);
      if (ProposalSeq != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ProposalSeq);
      }
      proposals_.WriteTo(ref output, _repeated_proposals_codec);
      votes_.WriteTo(ref output, _repeated_votes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GroupSeq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(GroupSeq);
      }
      size += groups_.CalculateSize(_repeated_groups_codec);
      size += groupMembers_.CalculateSize(_repeated_groupMembers_codec);
      if (GroupPolicySeq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(GroupPolicySeq);
      }
      size += groupPolicies_.CalculateSize(_repeated_groupPolicies_codec);
      if (ProposalSeq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ProposalSeq);
      }
      size += proposals_.CalculateSize(_repeated_proposals_codec);
      size += votes_.CalculateSize(_repeated_votes_codec);
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
      if (other.GroupSeq != 0UL) {
        GroupSeq = other.GroupSeq;
      }
      groups_.Add(other.groups_);
      groupMembers_.Add(other.groupMembers_);
      if (other.GroupPolicySeq != 0UL) {
        GroupPolicySeq = other.GroupPolicySeq;
      }
      groupPolicies_.Add(other.groupPolicies_);
      if (other.ProposalSeq != 0UL) {
        ProposalSeq = other.ProposalSeq;
      }
      proposals_.Add(other.proposals_);
      votes_.Add(other.votes_);
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
            GroupSeq = input.ReadUInt64();
            break;
          }
          case 18: {
            groups_.AddEntriesFrom(input, _repeated_groups_codec);
            break;
          }
          case 26: {
            groupMembers_.AddEntriesFrom(input, _repeated_groupMembers_codec);
            break;
          }
          case 32: {
            GroupPolicySeq = input.ReadUInt64();
            break;
          }
          case 42: {
            groupPolicies_.AddEntriesFrom(input, _repeated_groupPolicies_codec);
            break;
          }
          case 48: {
            ProposalSeq = input.ReadUInt64();
            break;
          }
          case 58: {
            proposals_.AddEntriesFrom(input, _repeated_proposals_codec);
            break;
          }
          case 66: {
            votes_.AddEntriesFrom(input, _repeated_votes_codec);
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
            GroupSeq = input.ReadUInt64();
            break;
          }
          case 18: {
            groups_.AddEntriesFrom(ref input, _repeated_groups_codec);
            break;
          }
          case 26: {
            groupMembers_.AddEntriesFrom(ref input, _repeated_groupMembers_codec);
            break;
          }
          case 32: {
            GroupPolicySeq = input.ReadUInt64();
            break;
          }
          case 42: {
            groupPolicies_.AddEntriesFrom(ref input, _repeated_groupPolicies_codec);
            break;
          }
          case 48: {
            ProposalSeq = input.ReadUInt64();
            break;
          }
          case 58: {
            proposals_.AddEntriesFrom(ref input, _repeated_proposals_codec);
            break;
          }
          case 66: {
            votes_.AddEntriesFrom(ref input, _repeated_votes_codec);
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