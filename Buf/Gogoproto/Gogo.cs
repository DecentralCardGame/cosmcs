// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gogoproto/gogo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Gogoproto {

  /// <summary>Holder for reflection information generated from gogoproto/gogo.proto</summary>
  public static partial class GogoReflection {

    #region Descriptor
    /// <summary>File descriptor for gogoproto/gogo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GogoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRnb2dvcHJvdG8vZ29nby5wcm90bxIJZ29nb3Byb3RvGiBnb29nbGUvcHJv",
            "dG9idWYvZGVzY3JpcHRvci5wcm90bzpOChNnb3Byb3RvX2VudW1fcHJlZml4",
            "EhwuZ29vZ2xlLnByb3RvYnVmLkVudW1PcHRpb25zGLHkAyABKAhSEWdvcHJv",
            "dG9FbnVtUHJlZml4OlIKFWdvcHJvdG9fZW51bV9zdHJpbmdlchIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5FbnVtT3B0aW9ucxjF5AMgASgIUhNnb3Byb3RvRW51bVN0",
            "cmluZ2VyOkMKDWVudW1fc3RyaW5nZXISHC5nb29nbGUucHJvdG9idWYuRW51",
            "bU9wdGlvbnMYxuQDIAEoCFIMZW51bVN0cmluZ2VyOkcKD2VudW1fY3VzdG9t",
            "bmFtZRIcLmdvb2dsZS5wcm90b2J1Zi5FbnVtT3B0aW9ucxjH5AMgASgJUg5l",
            "bnVtQ3VzdG9tbmFtZTo6CghlbnVtZGVjbBIcLmdvb2dsZS5wcm90b2J1Zi5F",
            "bnVtT3B0aW9ucxjI5AMgASgIUghlbnVtZGVjbDpWChRlbnVtdmFsdWVfY3Vz",
            "dG9tbmFtZRIhLmdvb2dsZS5wcm90b2J1Zi5FbnVtVmFsdWVPcHRpb25zGNGD",
            "BCABKAlSE2VudW12YWx1ZUN1c3RvbW5hbWU6TgoTZ29wcm90b19nZXR0ZXJz",
            "X2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxiZ7AMgASgIUhFn",
            "b3Byb3RvR2V0dGVyc0FsbDpVChdnb3Byb3RvX2VudW1fcHJlZml4X2FsbBIc",
            "Lmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxia7AMgASgIUhRnb3Byb3Rv",
            "RW51bVByZWZpeEFsbDpQChRnb3Byb3RvX3N0cmluZ2VyX2FsbBIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxib7AMgASgIUhJnb3Byb3RvU3RyaW5n",
            "ZXJBbGw6SgoRdmVyYm9zZV9lcXVhbF9hbGwSHC5nb29nbGUucHJvdG9idWYu",
            "RmlsZU9wdGlvbnMYnOwDIAEoCFIPdmVyYm9zZUVxdWFsQWxsOjkKCGZhY2Vf",
            "YWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGJ3sAyABKAhSB2Zh",
            "Y2VBbGw6QQoMZ29zdHJpbmdfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVP",
            "cHRpb25zGJ7sAyABKAhSC2dvc3RyaW5nQWxsOkEKDHBvcHVsYXRlX2FsbBIc",
            "Lmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxif7AMgASgIUgtwb3B1bGF0",
            "ZUFsbDpBCgxzdHJpbmdlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9w",
            "dGlvbnMYoOwDIAEoCFILc3RyaW5nZXJBbGw6PwoLb25seW9uZV9hbGwSHC5n",
            "b29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYoewDIAEoCFIKb25seW9uZUFs",
            "bDo7CgllcXVhbF9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY",
            "pewDIAEoCFIIZXF1YWxBbGw6RwoPZGVzY3JpcHRpb25fYWxsEhwuZ29vZ2xl",
            "LnByb3RvYnVmLkZpbGVPcHRpb25zGKbsAyABKAhSDmRlc2NyaXB0aW9uQWxs",
            "Oj8KC3Rlc3RnZW5fYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25z",
            "GKfsAyABKAhSCnRlc3RnZW5BbGw6QQoMYmVuY2hnZW5fYWxsEhwuZ29vZ2xl",
            "LnByb3RvYnVmLkZpbGVPcHRpb25zGKjsAyABKAhSC2JlbmNoZ2VuQWxsOkMK",
            "DW1hcnNoYWxlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY",
            "qewDIAEoCFIMbWFyc2hhbGVyQWxsOkcKD3VubWFyc2hhbGVyX2FsbBIcLmdv",
            "b2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxiq7AMgASgIUg51bm1hcnNoYWxl",
            "ckFsbDpQChRzdGFibGVfbWFyc2hhbGVyX2FsbBIcLmdvb2dsZS5wcm90b2J1",
            "Zi5GaWxlT3B0aW9ucxir7AMgASgIUhJzdGFibGVNYXJzaGFsZXJBbGw6OwoJ",
            "c2l6ZXJfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGKzsAyAB",
            "KAhSCHNpemVyQWxsOlkKGWdvcHJvdG9fZW51bV9zdHJpbmdlcl9hbGwSHC5n",
            "b29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYrewDIAEoCFIWZ29wcm90b0Vu",
            "dW1TdHJpbmdlckFsbDpKChFlbnVtX3N0cmluZ2VyX2FsbBIcLmdvb2dsZS5w",
            "cm90b2J1Zi5GaWxlT3B0aW9ucxiu7AMgASgIUg9lbnVtU3RyaW5nZXJBbGw6",
            "UAoUdW5zYWZlX21hcnNoYWxlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmls",
            "ZU9wdGlvbnMYr+wDIAEoCFISdW5zYWZlTWFyc2hhbGVyQWxsOlQKFnVuc2Fm",
            "ZV91bm1hcnNoYWxlcl9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlv",
            "bnMYsOwDIAEoCFIUdW5zYWZlVW5tYXJzaGFsZXJBbGw6WwoaZ29wcm90b19l",
            "eHRlbnNpb25zX21hcF9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlv",
            "bnMYsewDIAEoCFIXZ29wcm90b0V4dGVuc2lvbnNNYXBBbGw6WAoYZ29wcm90",
            "b191bnJlY29nbml6ZWRfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRp",
            "b25zGLLsAyABKAhSFmdvcHJvdG9VbnJlY29nbml6ZWRBbGw6SQoQZ29nb3By",
            "b3RvX2ltcG9ydBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxiz7AMg",
            "ASgIUg9nb2dvcHJvdG9JbXBvcnQ6RQoOcHJvdG9zaXplcl9hbGwSHC5nb29n",
            "bGUucHJvdG9idWYuRmlsZU9wdGlvbnMYtOwDIAEoCFINcHJvdG9zaXplckFs",
            "bDo/Cgtjb21wYXJlX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9u",
            "cxi17AMgASgIUgpjb21wYXJlQWxsOkEKDHR5cGVkZWNsX2FsbBIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxi27AMgASgIUgt0eXBlZGVjbEFsbDpB",
            "CgxlbnVtZGVjbF9hbGwSHC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMY",
            "t+wDIAEoCFILZW51bWRlY2xBbGw6UQoUZ29wcm90b19yZWdpc3RyYXRpb24S",
            "HC5nb29nbGUucHJvdG9idWYuRmlsZU9wdGlvbnMYuOwDIAEoCFITZ29wcm90",
            "b1JlZ2lzdHJhdGlvbjpHCg9tZXNzYWdlbmFtZV9hbGwSHC5nb29nbGUucHJv",
            "dG9idWYuRmlsZU9wdGlvbnMYuewDIAEoCFIObWVzc2FnZW5hbWVBbGw6UgoV",
            "Z29wcm90b19zaXplY2FjaGVfYWxsEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVP",
            "cHRpb25zGLrsAyABKAhSE2dvcHJvdG9TaXplY2FjaGVBbGw6TgoTZ29wcm90",
            "b191bmtleWVkX2FsbBIcLmdvb2dsZS5wcm90b2J1Zi5GaWxlT3B0aW9ucxi7",
            "7AMgASgIUhFnb3Byb3RvVW5rZXllZEFsbDpKCg9nb3Byb3RvX2dldHRlcnMS",
            "Hy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYgfQDIAEoCFIOZ29w",
            "cm90b0dldHRlcnM6TAoQZ29wcm90b19zdHJpbmdlchIfLmdvb2dsZS5wcm90",
            "b2J1Zi5NZXNzYWdlT3B0aW9ucxiD9AMgASgIUg9nb3Byb3RvU3RyaW5nZXI6",
            "RgoNdmVyYm9zZV9lcXVhbBIfLmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0",
            "aW9ucxiE9AMgASgIUgx2ZXJib3NlRXF1YWw6NQoEZmFjZRIfLmdvb2dsZS5w",
            "cm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiF9AMgASgIUgRmYWNlOj0KCGdvc3Ry",
            "aW5nEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGIb0AyABKAhS",
            "CGdvc3RyaW5nOj0KCHBvcHVsYXRlEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3Nh",
            "Z2VPcHRpb25zGIf0AyABKAhSCHBvcHVsYXRlOj0KCHN0cmluZ2VyEh8uZ29v",
            "Z2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGMCLBCABKAhSCHN0cmluZ2Vy",
            "OjsKB29ubHlvbmUSHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMY",
            "ifQDIAEoCFIHb25seW9uZTo3CgVlcXVhbBIfLmdvb2dsZS5wcm90b2J1Zi5N",
            "ZXNzYWdlT3B0aW9ucxiN9AMgASgIUgVlcXVhbDpDCgtkZXNjcmlwdGlvbhIf",
            "Lmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiO9AMgASgIUgtkZXNj",
            "cmlwdGlvbjo7Cgd0ZXN0Z2VuEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VP",
            "cHRpb25zGI/0AyABKAhSB3Rlc3RnZW46PQoIYmVuY2hnZW4SHy5nb29nbGUu",
            "cHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYkPQDIAEoCFIIYmVuY2hnZW46PwoJ",
            "bWFyc2hhbGVyEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGJH0",
            "AyABKAhSCW1hcnNoYWxlcjpDCgt1bm1hcnNoYWxlchIfLmdvb2dsZS5wcm90",
            "b2J1Zi5NZXNzYWdlT3B0aW9ucxiS9AMgASgIUgt1bm1hcnNoYWxlcjpMChBz",
            "dGFibGVfbWFyc2hhbGVyEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRp",
            "b25zGJP0AyABKAhSD3N0YWJsZU1hcnNoYWxlcjo3CgVzaXplchIfLmdvb2ds",
            "ZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiU9AMgASgIUgVzaXplcjpMChB1",
            "bnNhZmVfbWFyc2hhbGVyEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRp",
            "b25zGJf0AyABKAhSD3Vuc2FmZU1hcnNoYWxlcjpQChJ1bnNhZmVfdW5tYXJz",
            "aGFsZXISHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYmPQDIAEo",
            "CFIRdW5zYWZlVW5tYXJzaGFsZXI6VwoWZ29wcm90b19leHRlbnNpb25zX21h",
            "cBIfLmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxiZ9AMgASgIUhRn",
            "b3Byb3RvRXh0ZW5zaW9uc01hcDpUChRnb3Byb3RvX3VucmVjb2duaXplZBIf",
            "Lmdvb2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxia9AMgASgIUhNnb3By",
            "b3RvVW5yZWNvZ25pemVkOkEKCnByb3Rvc2l6ZXISHy5nb29nbGUucHJvdG9i",
            "dWYuTWVzc2FnZU9wdGlvbnMYnPQDIAEoCFIKcHJvdG9zaXplcjo7Cgdjb21w",
            "YXJlEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGJ30AyABKAhS",
            "B2NvbXBhcmU6PQoIdHlwZWRlY2wSHy5nb29nbGUucHJvdG9idWYuTWVzc2Fn",
            "ZU9wdGlvbnMYnvQDIAEoCFIIdHlwZWRlY2w6QwoLbWVzc2FnZW5hbWUSHy5n",
            "b29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYofQDIAEoCFILbWVzc2Fn",
            "ZW5hbWU6TgoRZ29wcm90b19zaXplY2FjaGUSHy5nb29nbGUucHJvdG9idWYu",
            "TWVzc2FnZU9wdGlvbnMYovQDIAEoCFIQZ29wcm90b1NpemVjYWNoZTpKCg9n",
            "b3Byb3RvX3Vua2V5ZWQSHy5nb29nbGUucHJvdG9idWYuTWVzc2FnZU9wdGlv",
            "bnMYo/QDIAEoCFIOZ29wcm90b1Vua2V5ZWQ6OwoIbnVsbGFibGUSHS5nb29n",
            "bGUucHJvdG9idWYuRmllbGRPcHRpb25zGOn7AyABKAhSCG51bGxhYmxlOjUK",
            "BWVtYmVkEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjq+wMgASgI",
            "UgVlbWJlZDo/CgpjdXN0b210eXBlEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxk",
            "T3B0aW9ucxjr+wMgASgJUgpjdXN0b210eXBlOj8KCmN1c3RvbW5hbWUSHS5n",
            "b29nbGUucHJvdG9idWYuRmllbGRPcHRpb25zGOz7AyABKAlSCmN1c3RvbW5h",
            "bWU6OQoHanNvbnRhZxIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY",
            "7fsDIAEoCVIHanNvbnRhZzo7Cghtb3JldGFncxIdLmdvb2dsZS5wcm90b2J1",
            "Zi5GaWVsZE9wdGlvbnMY7vsDIAEoCVIIbW9yZXRhZ3M6OwoIY2FzdHR5cGUS",
            "HS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRpb25zGO/7AyABKAlSCGNhc3R0",
            "eXBlOjkKB2Nhc3RrZXkSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRpb25z",
            "GPD7AyABKAlSB2Nhc3RrZXk6PQoJY2FzdHZhbHVlEh0uZ29vZ2xlLnByb3Rv",
            "YnVmLkZpZWxkT3B0aW9ucxjx+wMgASgJUgljYXN0dmFsdWU6OQoHc3RkdGlt",
            "ZRIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY8vsDIAEoCFIHc3Rk",
            "dGltZTpBCgtzdGRkdXJhdGlvbhIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9w",
            "dGlvbnMY8/sDIAEoCFILc3RkZHVyYXRpb246PwoKd2t0cG9pbnRlchIdLmdv",
            "b2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMY9PsDIAEoCFIKd2t0cG9pbnRl",
            "cjpDCgxjYXN0cmVwZWF0ZWQSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRp",
            "b25zGPX7AyABKAlSDGNhc3RyZXBlYXRlZEKFAQoNY29tLmdvZ29wcm90b0IJ",
            "R29nb1Byb3RvUAFaJWdpdGh1Yi5jb20vY29zbW9zL2dvZ29wcm90by9nb2dv",
            "cHJvdG+iAgNHWFiqAglHb2dvcHJvdG/KAglHb2dvcHJvdG/iAhVHb2dvcHJv",
            "dG9cR1BCTWV0YWRhdGHqAglHb2dvcHJvdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { GogoExtensions.GoprotoEnumPrefix, GogoExtensions.GoprotoEnumStringer, GogoExtensions.EnumStringer, GogoExtensions.EnumCustomname, GogoExtensions.Enumdecl, GogoExtensions.EnumvalueCustomname, GogoExtensions.GoprotoGettersAll, GogoExtensions.GoprotoEnumPrefixAll, GogoExtensions.GoprotoStringerAll, GogoExtensions.VerboseEqualAll, GogoExtensions.FaceAll, GogoExtensions.GostringAll, GogoExtensions.PopulateAll, GogoExtensions.StringerAll, GogoExtensions.OnlyoneAll, GogoExtensions.EqualAll, GogoExtensions.DescriptionAll, GogoExtensions.TestgenAll, GogoExtensions.BenchgenAll, GogoExtensions.MarshalerAll, GogoExtensions.UnmarshalerAll, GogoExtensions.StableMarshalerAll, GogoExtensions.SizerAll, GogoExtensions.GoprotoEnumStringerAll, GogoExtensions.EnumStringerAll, GogoExtensions.UnsafeMarshalerAll, GogoExtensions.UnsafeUnmarshalerAll, GogoExtensions.GoprotoExtensionsMapAll, GogoExtensions.GoprotoUnrecognizedAll, GogoExtensions.GogoprotoImport, GogoExtensions.ProtosizerAll, GogoExtensions.CompareAll, GogoExtensions.TypedeclAll, GogoExtensions.EnumdeclAll, GogoExtensions.GoprotoRegistration, GogoExtensions.MessagenameAll, GogoExtensions.GoprotoSizecacheAll, GogoExtensions.GoprotoUnkeyedAll, GogoExtensions.GoprotoGetters, GogoExtensions.GoprotoStringer, GogoExtensions.VerboseEqual, GogoExtensions.Face, GogoExtensions.Gostring, GogoExtensions.Populate, GogoExtensions.Stringer, GogoExtensions.Onlyone, GogoExtensions.Equal, GogoExtensions.Description, GogoExtensions.Testgen, GogoExtensions.Benchgen, GogoExtensions.Marshaler, GogoExtensions.Unmarshaler, GogoExtensions.StableMarshaler, GogoExtensions.Sizer, GogoExtensions.UnsafeMarshaler, GogoExtensions.UnsafeUnmarshaler, GogoExtensions.GoprotoExtensionsMap, GogoExtensions.GoprotoUnrecognized, GogoExtensions.Protosizer, GogoExtensions.Compare, GogoExtensions.Typedecl, GogoExtensions.Messagename, GogoExtensions.GoprotoSizecache, GogoExtensions.GoprotoUnkeyed, GogoExtensions.Nullable, GogoExtensions.Embed, GogoExtensions.Customtype, GogoExtensions.Customname, GogoExtensions.Jsontag, GogoExtensions.Moretags, GogoExtensions.Casttype, GogoExtensions.Castkey, GogoExtensions.Castvalue, GogoExtensions.Stdtime, GogoExtensions.Stdduration, GogoExtensions.Wktpointer, GogoExtensions.Castrepeated }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of gogoproto/gogo.proto</summary>
  public static partial class GogoExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> GoprotoEnumPrefix =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62001, pb::FieldCodec.ForBool(496008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> GoprotoEnumStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62021, pb::FieldCodec.ForBool(496168, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> EnumStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62022, pb::FieldCodec.ForBool(496176, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, string> EnumCustomname =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, string>(62023, pb::FieldCodec.ForString(496186, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool> Enumdecl =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, bool>(62024, pb::FieldCodec.ForBool(496192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, string> EnumvalueCustomname =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumValueOptions, string>(66001, pb::FieldCodec.ForString(528010, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoGettersAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63001, pb::FieldCodec.ForBool(504008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoEnumPrefixAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63002, pb::FieldCodec.ForBool(504016, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63003, pb::FieldCodec.ForBool(504024, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> VerboseEqualAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63004, pb::FieldCodec.ForBool(504032, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> FaceAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63005, pb::FieldCodec.ForBool(504040, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GostringAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63006, pb::FieldCodec.ForBool(504048, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> PopulateAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63007, pb::FieldCodec.ForBool(504056, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> StringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63008, pb::FieldCodec.ForBool(504064, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> OnlyoneAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63009, pb::FieldCodec.ForBool(504072, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EqualAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63013, pb::FieldCodec.ForBool(504104, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> DescriptionAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63014, pb::FieldCodec.ForBool(504112, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> TestgenAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63015, pb::FieldCodec.ForBool(504120, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> BenchgenAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63016, pb::FieldCodec.ForBool(504128, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> MarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63017, pb::FieldCodec.ForBool(504136, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnmarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63018, pb::FieldCodec.ForBool(504144, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> StableMarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63019, pb::FieldCodec.ForBool(504152, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> SizerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63020, pb::FieldCodec.ForBool(504160, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoEnumStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63021, pb::FieldCodec.ForBool(504168, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EnumStringerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63022, pb::FieldCodec.ForBool(504176, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnsafeMarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63023, pb::FieldCodec.ForBool(504184, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> UnsafeUnmarshalerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63024, pb::FieldCodec.ForBool(504192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoExtensionsMapAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63025, pb::FieldCodec.ForBool(504200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoUnrecognizedAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63026, pb::FieldCodec.ForBool(504208, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GogoprotoImport =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63027, pb::FieldCodec.ForBool(504216, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> ProtosizerAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63028, pb::FieldCodec.ForBool(504224, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> CompareAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63029, pb::FieldCodec.ForBool(504232, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> TypedeclAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63030, pb::FieldCodec.ForBool(504240, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> EnumdeclAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63031, pb::FieldCodec.ForBool(504248, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoRegistration =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63032, pb::FieldCodec.ForBool(504256, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> MessagenameAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63033, pb::FieldCodec.ForBool(504264, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoSizecacheAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63034, pb::FieldCodec.ForBool(504272, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool> GoprotoUnkeyedAll =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, bool>(63035, pb::FieldCodec.ForBool(504280, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoGetters =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64001, pb::FieldCodec.ForBool(512008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoStringer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64003, pb::FieldCodec.ForBool(512024, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> VerboseEqual =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64004, pb::FieldCodec.ForBool(512032, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Face =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64005, pb::FieldCodec.ForBool(512040, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Gostring =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64006, pb::FieldCodec.ForBool(512048, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Populate =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64007, pb::FieldCodec.ForBool(512056, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Stringer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(67008, pb::FieldCodec.ForBool(536064, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Onlyone =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64009, pb::FieldCodec.ForBool(512072, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Equal =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64013, pb::FieldCodec.ForBool(512104, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Description =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64014, pb::FieldCodec.ForBool(512112, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Testgen =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64015, pb::FieldCodec.ForBool(512120, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Benchgen =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64016, pb::FieldCodec.ForBool(512128, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Marshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64017, pb::FieldCodec.ForBool(512136, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Unmarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64018, pb::FieldCodec.ForBool(512144, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> StableMarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64019, pb::FieldCodec.ForBool(512152, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Sizer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64020, pb::FieldCodec.ForBool(512160, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> UnsafeMarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64023, pb::FieldCodec.ForBool(512184, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> UnsafeUnmarshaler =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64024, pb::FieldCodec.ForBool(512192, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoExtensionsMap =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64025, pb::FieldCodec.ForBool(512200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoUnrecognized =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64026, pb::FieldCodec.ForBool(512208, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Protosizer =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64028, pb::FieldCodec.ForBool(512224, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Compare =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64029, pb::FieldCodec.ForBool(512232, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Typedecl =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64030, pb::FieldCodec.ForBool(512240, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> Messagename =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64033, pb::FieldCodec.ForBool(512264, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoSizecache =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64034, pb::FieldCodec.ForBool(512272, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool> GoprotoUnkeyed =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, bool>(64035, pb::FieldCodec.ForBool(512280, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Nullable =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65001, pb::FieldCodec.ForBool(520008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Embed =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65002, pb::FieldCodec.ForBool(520016, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Customtype =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65003, pb::FieldCodec.ForString(520026, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Customname =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65004, pb::FieldCodec.ForString(520034, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Jsontag =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65005, pb::FieldCodec.ForString(520042, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Moretags =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65006, pb::FieldCodec.ForString(520050, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Casttype =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65007, pb::FieldCodec.ForString(520058, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Castkey =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65008, pb::FieldCodec.ForString(520066, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Castvalue =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65009, pb::FieldCodec.ForString(520074, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Stdtime =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65010, pb::FieldCodec.ForBool(520080, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Stdduration =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65011, pb::FieldCodec.ForBool(520088, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Wktpointer =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(65012, pb::FieldCodec.ForBool(520096, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Castrepeated =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(65013, pb::FieldCodec.ForString(520106, ""));
  }

}

#endregion Designer generated code
