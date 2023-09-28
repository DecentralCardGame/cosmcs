// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/msg/v1/msg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Msg.V1 {

  /// <summary>Holder for reflection information generated from cosmos/msg/v1/msg.proto</summary>
  public static partial class MsgReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/msg/v1/msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chdjb3Ntb3MvbXNnL3YxL21zZy5wcm90bxINY29zbW9zLm1zZy52MRogZ29v",
            "Z2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG86PAoHc2VydmljZRIfLmdv",
            "b2dsZS5wcm90b2J1Zi5TZXJ2aWNlT3B0aW9ucxjwjKYFIAEoCFIHc2Vydmlj",
            "ZTo6CgZzaWduZXISHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMY",
            "8IymBSADKAlSBnNpZ25lckKiAQoRY29tLmNvc21vcy5tc2cudjFCCE1zZ1By",
            "b3RvUAFaLWdpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlwZXMvbXNn",
            "c2VydmljZaICA0NNWKoCDUNvc21vcy5Nc2cuVjHKAg1Db3Ntb3NcTXNnXFYx",
            "4gIZQ29zbW9zXE1zZ1xWMVxHUEJNZXRhZGF0YeoCD0Nvc21vczo6TXNnOjpW",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { MsgExtensions.Service, MsgExtensions.Signer }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of cosmos/msg/v1/msg.proto</summary>
  public static partial class MsgExtensions {
    /// <summary>
    /// service indicates that the service is a Msg service and that requests
    /// must be transported via blockchain transactions rather than gRPC.
    /// Tooling can use this annotation to distinguish between Msg services and
    /// other types of services via reflection.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, bool> Service =
      new pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, bool>(11110000, pb::FieldCodec.ForBool(88880000, false));
    /// <summary>
    /// signer must be used in cosmos messages in order
    /// to signal to external clients which fields in a
    /// given cosmos message must be filled with signer
    /// information (address).
    /// The field must be the protobuf name of the message
    /// field extended with this MessageOption.
    /// The field must either be of string kind, or of message
    /// kind in case the signer information is contained within
    /// a message inside the cosmos message.
    /// </summary>
    public static readonly pb::RepeatedExtension<global::Google.Protobuf.Reflection.MessageOptions, string> Signer =
      new pb::RepeatedExtension<global::Google.Protobuf.Reflection.MessageOptions, string>(11110000, pb::FieldCodec.ForString(88880002));
  }

}

#endregion Designer generated code
