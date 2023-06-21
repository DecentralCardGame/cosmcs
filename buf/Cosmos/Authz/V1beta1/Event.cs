// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/authz/v1beta1/event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Authz.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/authz/v1beta1/event.proto</summary>
  public static partial class EventReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/authz/v1beta1/event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjb3Ntb3MvYXV0aHovdjFiZXRhMS9ldmVudC5wcm90bxIUY29zbW9zLmF1",
            "dGh6LnYxYmV0YTEaGWNvc21vc19wcm90by9jb3Ntb3MucHJvdG8ilgEKCkV2",
            "ZW50R3JhbnQSIAoMbXNnX3R5cGVfdXJsGAIgASgJUgptc2dUeXBlVXJsEjIK",
            "B2dyYW50ZXIYAyABKAlCGNK0LRRjb3Ntb3MuQWRkcmVzc1N0cmluZ1IHZ3Jh",
            "bnRlchIyCgdncmFudGVlGAQgASgJQhjStC0UY29zbW9zLkFkZHJlc3NTdHJp",
            "bmdSB2dyYW50ZWUilwEKC0V2ZW50UmV2b2tlEiAKDG1zZ190eXBlX3VybBgC",
            "IAEoCVIKbXNnVHlwZVVybBIyCgdncmFudGVyGAMgASgJQhjStC0UY29zbW9z",
            "LkFkZHJlc3NTdHJpbmdSB2dyYW50ZXISMgoHZ3JhbnRlZRgEIAEoCUIY0rQt",
            "FGNvc21vcy5BZGRyZXNzU3RyaW5nUgdncmFudGVlQr4BChhjb20uY29zbW9z",
            "LmF1dGh6LnYxYmV0YTFCCkV2ZW50UHJvdG9QAVokZ2l0aHViLmNvbS9jb3Nt",
            "b3MvY29zbW9zLXNkay94L2F1dGh6ogIDQ0FYqgIUQ29zbW9zLkF1dGh6LlYx",
            "YmV0YTHKAhRDb3Ntb3NcQXV0aHpcVjFiZXRhMeICIENvc21vc1xBdXRoelxW",
            "MWJldGExXEdQQk1ldGFkYXRh6gIWQ29zbW9zOjpBdXRoejo6VjFiZXRhMWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CosmosProto.CosmosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Authz.V1beta1.EventGrant), global::Cosmos.Authz.V1beta1.EventGrant.Parser, new[]{ "MsgTypeUrl", "Granter", "Grantee" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Authz.V1beta1.EventRevoke), global::Cosmos.Authz.V1beta1.EventRevoke.Parser, new[]{ "MsgTypeUrl", "Granter", "Grantee" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// EventGrant is emitted on Msg/Grant
  /// </summary>
  public sealed partial class EventGrant : pb::IMessage<EventGrant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventGrant> _parser = new pb::MessageParser<EventGrant>(() => new EventGrant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventGrant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Authz.V1beta1.EventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventGrant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventGrant(EventGrant other) : this() {
      msgTypeUrl_ = other.msgTypeUrl_;
      granter_ = other.granter_;
      grantee_ = other.grantee_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventGrant Clone() {
      return new EventGrant(this);
    }

    /// <summary>Field number for the "msg_type_url" field.</summary>
    public const int MsgTypeUrlFieldNumber = 2;
    private string msgTypeUrl_ = "";
    /// <summary>
    /// Msg type URL for which an autorization is granted
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MsgTypeUrl {
      get { return msgTypeUrl_; }
      set {
        msgTypeUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "granter" field.</summary>
    public const int GranterFieldNumber = 3;
    private string granter_ = "";
    /// <summary>
    /// Granter account address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Granter {
      get { return granter_; }
      set {
        granter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "grantee" field.</summary>
    public const int GranteeFieldNumber = 4;
    private string grantee_ = "";
    /// <summary>
    /// Grantee account address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Grantee {
      get { return grantee_; }
      set {
        grantee_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventGrant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventGrant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgTypeUrl != other.MsgTypeUrl) return false;
      if (Granter != other.Granter) return false;
      if (Grantee != other.Grantee) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgTypeUrl.Length != 0) hash ^= MsgTypeUrl.GetHashCode();
      if (Granter.Length != 0) hash ^= Granter.GetHashCode();
      if (Grantee.Length != 0) hash ^= Grantee.GetHashCode();
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
      if (MsgTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Granter);
      }
      if (Grantee.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Grantee);
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
      if (MsgTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Granter);
      }
      if (Grantee.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Grantee);
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
      if (MsgTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Granter);
      }
      if (Grantee.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Grantee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventGrant other) {
      if (other == null) {
        return;
      }
      if (other.MsgTypeUrl.Length != 0) {
        MsgTypeUrl = other.MsgTypeUrl;
      }
      if (other.Granter.Length != 0) {
        Granter = other.Granter;
      }
      if (other.Grantee.Length != 0) {
        Grantee = other.Grantee;
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
          case 18: {
            MsgTypeUrl = input.ReadString();
            break;
          }
          case 26: {
            Granter = input.ReadString();
            break;
          }
          case 34: {
            Grantee = input.ReadString();
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
          case 18: {
            MsgTypeUrl = input.ReadString();
            break;
          }
          case 26: {
            Granter = input.ReadString();
            break;
          }
          case 34: {
            Grantee = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// EventRevoke is emitted on Msg/Revoke
  /// </summary>
  public sealed partial class EventRevoke : pb::IMessage<EventRevoke>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventRevoke> _parser = new pb::MessageParser<EventRevoke>(() => new EventRevoke());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventRevoke> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Authz.V1beta1.EventReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventRevoke() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventRevoke(EventRevoke other) : this() {
      msgTypeUrl_ = other.msgTypeUrl_;
      granter_ = other.granter_;
      grantee_ = other.grantee_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventRevoke Clone() {
      return new EventRevoke(this);
    }

    /// <summary>Field number for the "msg_type_url" field.</summary>
    public const int MsgTypeUrlFieldNumber = 2;
    private string msgTypeUrl_ = "";
    /// <summary>
    /// Msg type URL for which an autorization is revoked
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MsgTypeUrl {
      get { return msgTypeUrl_; }
      set {
        msgTypeUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "granter" field.</summary>
    public const int GranterFieldNumber = 3;
    private string granter_ = "";
    /// <summary>
    /// Granter account address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Granter {
      get { return granter_; }
      set {
        granter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "grantee" field.</summary>
    public const int GranteeFieldNumber = 4;
    private string grantee_ = "";
    /// <summary>
    /// Grantee account address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Grantee {
      get { return grantee_; }
      set {
        grantee_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventRevoke);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventRevoke other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgTypeUrl != other.MsgTypeUrl) return false;
      if (Granter != other.Granter) return false;
      if (Grantee != other.Grantee) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgTypeUrl.Length != 0) hash ^= MsgTypeUrl.GetHashCode();
      if (Granter.Length != 0) hash ^= Granter.GetHashCode();
      if (Grantee.Length != 0) hash ^= Grantee.GetHashCode();
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
      if (MsgTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Granter);
      }
      if (Grantee.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Grantee);
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
      if (MsgTypeUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Granter);
      }
      if (Grantee.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Grantee);
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
      if (MsgTypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgTypeUrl);
      }
      if (Granter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Granter);
      }
      if (Grantee.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Grantee);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventRevoke other) {
      if (other == null) {
        return;
      }
      if (other.MsgTypeUrl.Length != 0) {
        MsgTypeUrl = other.MsgTypeUrl;
      }
      if (other.Granter.Length != 0) {
        Granter = other.Granter;
      }
      if (other.Grantee.Length != 0) {
        Grantee = other.Grantee;
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
          case 18: {
            MsgTypeUrl = input.ReadString();
            break;
          }
          case 26: {
            Granter = input.ReadString();
            break;
          }
          case 34: {
            Grantee = input.ReadString();
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
          case 18: {
            MsgTypeUrl = input.ReadString();
            break;
          }
          case 26: {
            Granter = input.ReadString();
            break;
          }
          case 34: {
            Grantee = input.ReadString();
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