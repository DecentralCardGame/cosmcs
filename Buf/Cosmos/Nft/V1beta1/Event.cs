// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/nft/v1beta1/event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Nft.V1beta1 {

  /// <summary>Holder for reflection information generated from cosmos/nft/v1beta1/event.proto</summary>
  public static partial class EventReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/nft/v1beta1/event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5jb3Ntb3MvbmZ0L3YxYmV0YTEvZXZlbnQucHJvdG8SEmNvc21vcy5uZnQu",
            "djFiZXRhMSJqCglFdmVudFNlbmQSGQoIY2xhc3NfaWQYASABKAlSB2NsYXNz",
            "SWQSDgoCaWQYAiABKAlSAmlkEhYKBnNlbmRlchgDIAEoCVIGc2VuZGVyEhoK",
            "CHJlY2VpdmVyGAQgASgJUghyZWNlaXZlciJMCglFdmVudE1pbnQSGQoIY2xh",
            "c3NfaWQYASABKAlSB2NsYXNzSWQSDgoCaWQYAiABKAlSAmlkEhQKBW93bmVy",
            "GAMgASgJUgVvd25lciJMCglFdmVudEJ1cm4SGQoIY2xhc3NfaWQYASABKAlS",
            "B2NsYXNzSWQSDgoCaWQYAiABKAlSAmlkEhQKBW93bmVyGAMgASgJUgVvd25l",
            "ckKyAQoWY29tLmNvc21vcy5uZnQudjFiZXRhMUIKRXZlbnRQcm90b1ABWiJn",
            "aXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL3gvbmZ0ogIDQ05YqgISQ29z",
            "bW9zLk5mdC5WMWJldGExygISQ29zbW9zXE5mdFxWMWJldGEx4gIeQ29zbW9z",
            "XE5mdFxWMWJldGExXEdQQk1ldGFkYXRh6gIUQ29zbW9zOjpOZnQ6OlYxYmV0",
            "YTFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Nft.V1beta1.EventSend), global::Cosmos.Nft.V1beta1.EventSend.Parser, new[]{ "ClassId", "Id", "Sender", "Receiver" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Nft.V1beta1.EventMint), global::Cosmos.Nft.V1beta1.EventMint.Parser, new[]{ "ClassId", "Id", "Owner" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Nft.V1beta1.EventBurn), global::Cosmos.Nft.V1beta1.EventBurn.Parser, new[]{ "ClassId", "Id", "Owner" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// EventSend is emitted on Msg/Send
  /// </summary>
  public sealed partial class EventSend : pb::IMessage<EventSend>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventSend> _parser = new pb::MessageParser<EventSend>(() => new EventSend());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventSend> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Nft.V1beta1.EventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventSend() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventSend(EventSend other) : this() {
      classId_ = other.classId_;
      id_ = other.id_;
      sender_ = other.sender_;
      receiver_ = other.receiver_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventSend Clone() {
      return new EventSend(this);
    }

    /// <summary>Field number for the "class_id" field.</summary>
    public const int ClassIdFieldNumber = 1;
    private string classId_ = "";
    /// <summary>
    /// class_id associated with the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClassId {
      get { return classId_; }
      set {
        classId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// id is a unique identifier of the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 3;
    private string sender_ = "";
    /// <summary>
    /// sender is the address of the owner of nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "receiver" field.</summary>
    public const int ReceiverFieldNumber = 4;
    private string receiver_ = "";
    /// <summary>
    /// receiver is the receiver address of nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Receiver {
      get { return receiver_; }
      set {
        receiver_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventSend);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventSend other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassId != other.ClassId) return false;
      if (Id != other.Id) return false;
      if (Sender != other.Sender) return false;
      if (Receiver != other.Receiver) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassId.Length != 0) hash ^= ClassId.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (Receiver.Length != 0) hash ^= Receiver.GetHashCode();
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sender);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Receiver);
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sender);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Receiver);
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
      if (ClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassId);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (Receiver.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Receiver);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventSend other) {
      if (other == null) {
        return;
      }
      if (other.ClassId.Length != 0) {
        ClassId = other.ClassId;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      if (other.Receiver.Length != 0) {
        Receiver = other.Receiver;
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Sender = input.ReadString();
            break;
          }
          case 34: {
            Receiver = input.ReadString();
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Sender = input.ReadString();
            break;
          }
          case 34: {
            Receiver = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// EventMint is emitted on Mint
  /// </summary>
  public sealed partial class EventMint : pb::IMessage<EventMint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventMint> _parser = new pb::MessageParser<EventMint>(() => new EventMint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventMint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Nft.V1beta1.EventReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventMint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventMint(EventMint other) : this() {
      classId_ = other.classId_;
      id_ = other.id_;
      owner_ = other.owner_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventMint Clone() {
      return new EventMint(this);
    }

    /// <summary>Field number for the "class_id" field.</summary>
    public const int ClassIdFieldNumber = 1;
    private string classId_ = "";
    /// <summary>
    /// class_id associated with the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClassId {
      get { return classId_; }
      set {
        classId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// id is a unique identifier of the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "owner" field.</summary>
    public const int OwnerFieldNumber = 3;
    private string owner_ = "";
    /// <summary>
    /// owner is the owner address of the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Owner {
      get { return owner_; }
      set {
        owner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventMint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventMint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassId != other.ClassId) return false;
      if (Id != other.Id) return false;
      if (Owner != other.Owner) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassId.Length != 0) hash ^= ClassId.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Owner.Length != 0) hash ^= Owner.GetHashCode();
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Owner);
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Owner);
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
      if (ClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassId);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Owner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Owner);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventMint other) {
      if (other == null) {
        return;
      }
      if (other.ClassId.Length != 0) {
        ClassId = other.ClassId;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Owner.Length != 0) {
        Owner = other.Owner;
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Owner = input.ReadString();
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Owner = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// EventBurn is emitted on Burn
  /// </summary>
  public sealed partial class EventBurn : pb::IMessage<EventBurn>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EventBurn> _parser = new pb::MessageParser<EventBurn>(() => new EventBurn());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EventBurn> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Nft.V1beta1.EventReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBurn() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBurn(EventBurn other) : this() {
      classId_ = other.classId_;
      id_ = other.id_;
      owner_ = other.owner_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EventBurn Clone() {
      return new EventBurn(this);
    }

    /// <summary>Field number for the "class_id" field.</summary>
    public const int ClassIdFieldNumber = 1;
    private string classId_ = "";
    /// <summary>
    /// class_id associated with the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClassId {
      get { return classId_; }
      set {
        classId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// id is a unique identifier of the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "owner" field.</summary>
    public const int OwnerFieldNumber = 3;
    private string owner_ = "";
    /// <summary>
    /// owner is the owner address of the nft
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Owner {
      get { return owner_; }
      set {
        owner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EventBurn);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EventBurn other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassId != other.ClassId) return false;
      if (Id != other.Id) return false;
      if (Owner != other.Owner) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassId.Length != 0) hash ^= ClassId.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Owner.Length != 0) hash ^= Owner.GetHashCode();
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Owner);
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
      if (ClassId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Owner);
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
      if (ClassId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassId);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Owner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Owner);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EventBurn other) {
      if (other == null) {
        return;
      }
      if (other.ClassId.Length != 0) {
        ClassId = other.ClassId;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Owner.Length != 0) {
        Owner = other.Owner;
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Owner = input.ReadString();
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
            ClassId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            Owner = input.ReadString();
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