// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/store/streaming/abci/grpc.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Store.Streaming.Abci {
  /// <summary>
  /// ABCIListenerService is the service for the BaseApp ABCIListener interface
  /// </summary>
  public static partial class ABCIListenerService
  {
    static readonly string __ServiceName = "cosmos.store.streaming.abci.ABCIListenerService";

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
    static readonly grpc::Marshaller<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest> __Marshaller_cosmos_store_streaming_abci_ListenFinalizeBlockRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse> __Marshaller_cosmos_store_streaming_abci_ListenFinalizeBlockResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Store.Streaming.Abci.ListenCommitRequest> __Marshaller_cosmos_store_streaming_abci_ListenCommitRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Store.Streaming.Abci.ListenCommitRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Store.Streaming.Abci.ListenCommitResponse> __Marshaller_cosmos_store_streaming_abci_ListenCommitResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Store.Streaming.Abci.ListenCommitResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest, global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse> __Method_ListenFinalizeBlock = new grpc::Method<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest, global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListenFinalizeBlock",
        __Marshaller_cosmos_store_streaming_abci_ListenFinalizeBlockRequest,
        __Marshaller_cosmos_store_streaming_abci_ListenFinalizeBlockResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Store.Streaming.Abci.ListenCommitRequest, global::Cosmos.Store.Streaming.Abci.ListenCommitResponse> __Method_ListenCommit = new grpc::Method<global::Cosmos.Store.Streaming.Abci.ListenCommitRequest, global::Cosmos.Store.Streaming.Abci.ListenCommitResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListenCommit",
        __Marshaller_cosmos_store_streaming_abci_ListenCommitRequest,
        __Marshaller_cosmos_store_streaming_abci_ListenCommitResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Store.Streaming.Abci.GrpcReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ABCIListenerService</summary>
    public partial class ABCIListenerServiceClient : grpc::ClientBase<ABCIListenerServiceClient>
    {
      /// <summary>Creates a new client for ABCIListenerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ABCIListenerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ABCIListenerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ABCIListenerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ABCIListenerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ABCIListenerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// ListenFinalizeBlock is the corresponding endpoint for ABCIListener.ListenEndBlock
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse ListenFinalizeBlock(global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenFinalizeBlock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListenFinalizeBlock is the corresponding endpoint for ABCIListener.ListenEndBlock
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse ListenFinalizeBlock(global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListenFinalizeBlock, null, options, request);
      }
      /// <summary>
      /// ListenFinalizeBlock is the corresponding endpoint for ABCIListener.ListenEndBlock
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse> ListenFinalizeBlockAsync(global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenFinalizeBlockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListenFinalizeBlock is the corresponding endpoint for ABCIListener.ListenEndBlock
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockResponse> ListenFinalizeBlockAsync(global::Cosmos.Store.Streaming.Abci.ListenFinalizeBlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListenFinalizeBlock, null, options, request);
      }
      /// <summary>
      /// ListenCommit is the corresponding endpoint for ABCIListener.ListenCommit
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Store.Streaming.Abci.ListenCommitResponse ListenCommit(global::Cosmos.Store.Streaming.Abci.ListenCommitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenCommit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListenCommit is the corresponding endpoint for ABCIListener.ListenCommit
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Store.Streaming.Abci.ListenCommitResponse ListenCommit(global::Cosmos.Store.Streaming.Abci.ListenCommitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListenCommit, null, options, request);
      }
      /// <summary>
      /// ListenCommit is the corresponding endpoint for ABCIListener.ListenCommit
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Store.Streaming.Abci.ListenCommitResponse> ListenCommitAsync(global::Cosmos.Store.Streaming.Abci.ListenCommitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenCommitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ListenCommit is the corresponding endpoint for ABCIListener.ListenCommit
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Store.Streaming.Abci.ListenCommitResponse> ListenCommitAsync(global::Cosmos.Store.Streaming.Abci.ListenCommitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListenCommit, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ABCIListenerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ABCIListenerServiceClient(configuration);
      }
    }

  }
}
#endregion
