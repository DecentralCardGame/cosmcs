// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/query/v1/query.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Query.V1 {

  /// <summary>Holder for reflection information generated from cosmos/query/v1/query.proto</summary>
  public static partial class QueryReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/query/v1/query.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtjb3Ntb3MvcXVlcnkvdjEvcXVlcnkucHJvdG8SD2Nvc21vcy5xdWVyeS52",
            "MRogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG86TQoRbW9kdWxl",
            "X3F1ZXJ5X3NhZmUSHi5nb29nbGUucHJvdG9idWYuTWV0aG9kT3B0aW9ucxjx",
            "jKYFIAEoCFIPbW9kdWxlUXVlcnlTYWZlQrUBChNjb20uY29zbW9zLnF1ZXJ5",
            "LnYxQgpRdWVyeVByb3RvUAFaNGdpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1z",
            "ZGsvY29zbW9zL3F1ZXJ5L3YxO3F1ZXJ5djGiAgNDUViqAg9Db3Ntb3MuUXVl",
            "cnkuVjHKAg9Db3Ntb3NcUXVlcnlcVjHiAhtDb3Ntb3NcUXVlcnlcVjFcR1BC",
            "TWV0YWRhdGHqAhFDb3Ntb3M6OlF1ZXJ5OjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { QueryExtensions.ModuleQuerySafe }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of cosmos/query/v1/query.proto</summary>
  public static partial class QueryExtensions {
    /// <summary>
    /// module_query_safe is set to true when the query is safe to be called from
    /// within the state machine, for example from another module's Keeper, via
    /// ADR-033 calls or from CosmWasm contracts.
    /// Concretely, it means that the query is:
    /// 1. deterministic: given a block height, returns the exact same response
    /// upon multiple calls; and doesn't introduce any state-machine-breaking
    /// changes across SDK patch version.
    /// 2. consumes gas correctly.
    ///
    /// If you are a module developer and want to add this annotation to one of
    /// your own queries, please make sure that the corresponding query:
    /// 1. is deterministic and won't introduce state-machine-breaking changes
    /// without a coordinated upgrade path,
    /// 2. has its gas tracked, to avoid the attack vector where no gas is
    /// accounted for on potentially high-computation queries.
    ///
    /// For queries that potentially consume a large amount of gas (for example
    /// those with pagination, if the pagination field is incorrectly set), we
    /// also recommend adding Protobuf comments to warn module developers
    /// consuming these queries.
    ///
    /// When set to true, the query can safely be called
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, bool> ModuleQuerySafe =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, bool>(11110001, pb::FieldCodec.ForBool(88880008, false));
  }

}

#endregion Designer generated code
