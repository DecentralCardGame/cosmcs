// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/orm/query/v1alpha1/query.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Orm.Query.V1alpha1 {
  /// <summary>
  /// Query is a generic gRPC service for querying ORM data.
  /// </summary>
  public static partial class Query
  {
    static readonly string __ServiceName = "cosmos.orm.query.v1alpha1.Query";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Orm.Query.V1alpha1.GetRequest> __Marshaller_cosmos_orm_query_v1alpha1_GetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Orm.Query.V1alpha1.GetRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Orm.Query.V1alpha1.GetResponse> __Marshaller_cosmos_orm_query_v1alpha1_GetResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Orm.Query.V1alpha1.GetResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Orm.Query.V1alpha1.ListRequest> __Marshaller_cosmos_orm_query_v1alpha1_ListRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Orm.Query.V1alpha1.ListRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Orm.Query.V1alpha1.ListResponse> __Marshaller_cosmos_orm_query_v1alpha1_ListResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Orm.Query.V1alpha1.ListResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Orm.Query.V1alpha1.GetRequest, global::Cosmos.Orm.Query.V1alpha1.GetResponse> __Method_Get = new grpc::Method<global::Cosmos.Orm.Query.V1alpha1.GetRequest, global::Cosmos.Orm.Query.V1alpha1.GetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_cosmos_orm_query_v1alpha1_GetRequest,
        __Marshaller_cosmos_orm_query_v1alpha1_GetResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Orm.Query.V1alpha1.ListRequest, global::Cosmos.Orm.Query.V1alpha1.ListResponse> __Method_List = new grpc::Method<global::Cosmos.Orm.Query.V1alpha1.ListRequest, global::Cosmos.Orm.Query.V1alpha1.ListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_cosmos_orm_query_v1alpha1_ListRequest,
        __Marshaller_cosmos_orm_query_v1alpha1_ListResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Orm.Query.V1alpha1.QueryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Query</summary>
    [grpc::BindServiceMethod(typeof(Query), "BindService")]
    public abstract partial class QueryBase
    {
      /// <summary>
      /// Get queries an ORM table against an unique index.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Orm.Query.V1alpha1.GetResponse> Get(global::Cosmos.Orm.Query.V1alpha1.GetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// List queries an ORM table against an index.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Orm.Query.V1alpha1.ListResponse> List(global::Cosmos.Orm.Query.V1alpha1.ListRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Query</summary>
    public partial class QueryClient : grpc::ClientBase<QueryClient>
    {
      /// <summary>Creates a new client for Query</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public QueryClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Query that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public QueryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected QueryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected QueryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Get queries an ORM table against an unique index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Orm.Query.V1alpha1.GetResponse Get(global::Cosmos.Orm.Query.V1alpha1.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get queries an ORM table against an unique index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Orm.Query.V1alpha1.GetResponse Get(global::Cosmos.Orm.Query.V1alpha1.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Get queries an ORM table against an unique index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Orm.Query.V1alpha1.GetResponse> GetAsync(global::Cosmos.Orm.Query.V1alpha1.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get queries an ORM table against an unique index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Orm.Query.V1alpha1.GetResponse> GetAsync(global::Cosmos.Orm.Query.V1alpha1.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// List queries an ORM table against an index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Orm.Query.V1alpha1.ListResponse List(global::Cosmos.Orm.Query.V1alpha1.ListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List queries an ORM table against an index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Orm.Query.V1alpha1.ListResponse List(global::Cosmos.Orm.Query.V1alpha1.ListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// List queries an ORM table against an index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Orm.Query.V1alpha1.ListResponse> ListAsync(global::Cosmos.Orm.Query.V1alpha1.ListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List queries an ORM table against an index.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Orm.Query.V1alpha1.ListResponse> ListAsync(global::Cosmos.Orm.Query.V1alpha1.ListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override QueryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new QueryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(QueryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_List, serviceImpl.List).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, QueryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Orm.Query.V1alpha1.GetRequest, global::Cosmos.Orm.Query.V1alpha1.GetResponse>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_List, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Orm.Query.V1alpha1.ListRequest, global::Cosmos.Orm.Query.V1alpha1.ListResponse>(serviceImpl.List));
    }

  }
}
#endregion
