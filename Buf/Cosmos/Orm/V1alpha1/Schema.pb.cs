// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/orm/v1alpha1/schema.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Orm.V1alpha1 {

  /// <summary>Holder for reflection information generated from cosmos/orm/v1alpha1/schema.proto</summary>
  public static partial class SchemaReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/orm/v1alpha1/schema.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SchemaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjb3Ntb3Mvb3JtL3YxYWxwaGExL3NjaGVtYS5wcm90bxITY29zbW9zLm9y",
            "bS52MWFscGhhMRogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8i",
            "kwIKFk1vZHVsZVNjaGVtYURlc2NyaXB0b3ISVgoLc2NoZW1hX2ZpbGUYASAD",
            "KAsyNS5jb3Ntb3Mub3JtLnYxYWxwaGExLk1vZHVsZVNjaGVtYURlc2NyaXB0",
            "b3IuRmlsZUVudHJ5UgpzY2hlbWFGaWxlEhYKBnByZWZpeBgCIAEoDFIGcHJl",
            "Zml4GogBCglGaWxlRW50cnkSDgoCaWQYASABKA1SAmlkEiYKD3Byb3RvX2Zp",
            "bGVfbmFtZRgCIAEoCVINcHJvdG9GaWxlTmFtZRJDCgxzdG9yYWdlX3R5cGUY",
            "AyABKA4yIC5jb3Ntb3Mub3JtLnYxYWxwaGExLlN0b3JhZ2VUeXBlUgtzdG9y",
            "YWdlVHlwZSpoCgtTdG9yYWdlVHlwZRIkCiBTVE9SQUdFX1RZUEVfREVGQVVM",
            "VF9VTlNQRUNJRklFRBAAEhcKE1NUT1JBR0VfVFlQRV9NRU1PUlkQARIaChZT",
            "VE9SQUdFX1RZUEVfVFJBTlNJRU5UEAI6dAoNbW9kdWxlX3NjaGVtYRIfLmdv",
            "b2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxjws+oxIAEoCzIrLmNvc21v",
            "cy5vcm0udjFhbHBoYTEuTW9kdWxlU2NoZW1hRGVzY3JpcHRvclIMbW9kdWxl",
            "U2NoZW1hQtIBChdjb20uY29zbW9zLm9ybS52MWFscGhhMUILU2NoZW1hUHJv",
            "dG9QAVo8Z2l0aHViLmNvbS9jb3Ntb3MvY29zbW9zLXNkay9jb3Ntb3Mvb3Jt",
            "L3YxYWxwaGExO29ybXYxYWxwaGExogIDQ09YqgITQ29zbW9zLk9ybS5WMWFs",
            "cGhhMcoCE0Nvc21vc1xPcm1cVjFhbHBoYTHiAh9Db3Ntb3NcT3JtXFYxYWxw",
            "aGExXEdQQk1ldGFkYXRh6gIVQ29zbW9zOjpPcm06OlYxYWxwaGExYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cosmos.Orm.V1alpha1.StorageType), }, new pb::Extension[] { SchemaExtensions.ModuleSchema }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor), global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Parser, new[]{ "SchemaFile", "Prefix" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry), global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry.Parser, new[]{ "Id", "ProtoFileName", "StorageType" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of cosmos/orm/v1alpha1/schema.proto</summary>
  public static partial class SchemaExtensions {
    /// <summary>
    /// module_schema is used to define the ORM schema for an app module.
    /// All module config messages that use module_schema must also declare
    /// themselves as app module config messages using the cosmos.app.v1.is_module
    /// option.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor> ModuleSchema =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor>(104503792, pb::FieldCodec.ForMessage(836030338, global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Parser));
  }

  #region Enums
  /// <summary>
  /// StorageType
  /// </summary>
  public enum StorageType {
    /// <summary>
    /// STORAGE_TYPE_DEFAULT_UNSPECIFIED indicates the persistent storage where all
    /// data is stored in the regular Merkle-tree backed KV-store.
    /// </summary>
    [pbr::OriginalName("STORAGE_TYPE_DEFAULT_UNSPECIFIED")] DefaultUnspecified = 0,
    /// <summary>
    /// STORAGE_TYPE_MEMORY indicates in-memory storage that will be
    /// reloaded every time an app restarts. Tables with this type of storage
    /// will by default be ignored when importing and exporting a module's
    /// state from JSON.
    /// </summary>
    [pbr::OriginalName("STORAGE_TYPE_MEMORY")] Memory = 1,
    /// <summary>
    /// STORAGE_TYPE_TRANSIENT indicates transient storage that is reset
    /// at the end of every block. Tables with this type of storage
    /// will by default be ignored when importing and exporting a module's
    /// state from JSON.
    /// </summary>
    [pbr::OriginalName("STORAGE_TYPE_TRANSIENT")] Transient = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// ModuleSchemaDescriptor describe's a module's ORM schema.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ModuleSchemaDescriptor : pb::IMessage<ModuleSchemaDescriptor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ModuleSchemaDescriptor> _parser = new pb::MessageParser<ModuleSchemaDescriptor>(() => new ModuleSchemaDescriptor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ModuleSchemaDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Orm.V1alpha1.SchemaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleSchemaDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleSchemaDescriptor(ModuleSchemaDescriptor other) : this() {
      schemaFile_ = other.schemaFile_.Clone();
      prefix_ = other.prefix_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleSchemaDescriptor Clone() {
      return new ModuleSchemaDescriptor(this);
    }

    /// <summary>Field number for the "schema_file" field.</summary>
    public const int SchemaFileFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry> _repeated_schemaFile_codec
        = pb::FieldCodec.ForMessage(10, global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry> schemaFile_ = new pbc::RepeatedField<global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Types.FileEntry> SchemaFile {
      get { return schemaFile_; }
    }

    /// <summary>Field number for the "prefix" field.</summary>
    public const int PrefixFieldNumber = 2;
    private pb::ByteString prefix_ = pb::ByteString.Empty;
    /// <summary>
    /// prefix is an optional prefix that precedes all keys in this module's
    /// store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Prefix {
      get { return prefix_; }
      set {
        prefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ModuleSchemaDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ModuleSchemaDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!schemaFile_.Equals(other.schemaFile_)) return false;
      if (Prefix != other.Prefix) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= schemaFile_.GetHashCode();
      if (Prefix.Length != 0) hash ^= Prefix.GetHashCode();
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
      schemaFile_.WriteTo(output, _repeated_schemaFile_codec);
      if (Prefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Prefix);
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
      schemaFile_.WriteTo(ref output, _repeated_schemaFile_codec);
      if (Prefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Prefix);
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
      size += schemaFile_.CalculateSize(_repeated_schemaFile_codec);
      if (Prefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Prefix);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ModuleSchemaDescriptor other) {
      if (other == null) {
        return;
      }
      schemaFile_.Add(other.schemaFile_);
      if (other.Prefix.Length != 0) {
        Prefix = other.Prefix;
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
            schemaFile_.AddEntriesFrom(input, _repeated_schemaFile_codec);
            break;
          }
          case 18: {
            Prefix = input.ReadBytes();
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
            schemaFile_.AddEntriesFrom(ref input, _repeated_schemaFile_codec);
            break;
          }
          case 18: {
            Prefix = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ModuleSchemaDescriptor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// FileEntry describes an ORM file used in a module.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class FileEntry : pb::IMessage<FileEntry>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<FileEntry> _parser = new pb::MessageParser<FileEntry>(() => new FileEntry());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<FileEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Cosmos.Orm.V1alpha1.ModuleSchemaDescriptor.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileEntry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileEntry(FileEntry other) : this() {
          id_ = other.id_;
          protoFileName_ = other.protoFileName_;
          storageType_ = other.storageType_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileEntry Clone() {
          return new FileEntry(this);
        }

        /// <summary>Field number for the "id" field.</summary>
        public const int IdFieldNumber = 1;
        private uint id_;
        /// <summary>
        /// id is a prefix that will be varint encoded and prepended to all the
        /// table keys specified in the file's tables.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint Id {
          get { return id_; }
          set {
            id_ = value;
          }
        }

        /// <summary>Field number for the "proto_file_name" field.</summary>
        public const int ProtoFileNameFieldNumber = 2;
        private string protoFileName_ = "";
        /// <summary>
        /// proto_file_name is the name of a file .proto in that contains
        /// table definitions. The .proto file must be in a package that the
        /// module has referenced using cosmos.app.v1.ModuleDescriptor.use_package.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ProtoFileName {
          get { return protoFileName_; }
          set {
            protoFileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "storage_type" field.</summary>
        public const int StorageTypeFieldNumber = 3;
        private global::Cosmos.Orm.V1alpha1.StorageType storageType_ = global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified;
        /// <summary>
        /// storage_type optionally indicates the type of storage this file's
        /// tables should used. If it is left unspecified, the default KV-storage
        /// of the app will be used.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Cosmos.Orm.V1alpha1.StorageType StorageType {
          get { return storageType_; }
          set {
            storageType_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as FileEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(FileEntry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Id != other.Id) return false;
          if (ProtoFileName != other.ProtoFileName) return false;
          if (StorageType != other.StorageType) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Id != 0) hash ^= Id.GetHashCode();
          if (ProtoFileName.Length != 0) hash ^= ProtoFileName.GetHashCode();
          if (StorageType != global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified) hash ^= StorageType.GetHashCode();
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
          if (Id != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Id);
          }
          if (ProtoFileName.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ProtoFileName);
          }
          if (StorageType != global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified) {
            output.WriteRawTag(24);
            output.WriteEnum((int) StorageType);
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
          if (Id != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Id);
          }
          if (ProtoFileName.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ProtoFileName);
          }
          if (StorageType != global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified) {
            output.WriteRawTag(24);
            output.WriteEnum((int) StorageType);
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
          if (Id != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
          }
          if (ProtoFileName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ProtoFileName);
          }
          if (StorageType != global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StorageType);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(FileEntry other) {
          if (other == null) {
            return;
          }
          if (other.Id != 0) {
            Id = other.Id;
          }
          if (other.ProtoFileName.Length != 0) {
            ProtoFileName = other.ProtoFileName;
          }
          if (other.StorageType != global::Cosmos.Orm.V1alpha1.StorageType.DefaultUnspecified) {
            StorageType = other.StorageType;
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
                Id = input.ReadUInt32();
                break;
              }
              case 18: {
                ProtoFileName = input.ReadString();
                break;
              }
              case 24: {
                StorageType = (global::Cosmos.Orm.V1alpha1.StorageType) input.ReadEnum();
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
                Id = input.ReadUInt32();
                break;
              }
              case 18: {
                ProtoFileName = input.ReadString();
                break;
              }
              case 24: {
                StorageType = (global::Cosmos.Orm.V1alpha1.StorageType) input.ReadEnum();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
