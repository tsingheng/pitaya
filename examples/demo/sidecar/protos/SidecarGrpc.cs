// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: sidecar.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NPitaya.Protos {
  public static partial class Sidecar
  {
    static readonly string __ServiceName = "protos.Sidecar";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::NPitaya.Protos.RPCResponse> __Marshaller_protos_RPCResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.RPCResponse.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.SidecarRequest> __Marshaller_protos_SidecarRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.SidecarRequest.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.RequestTo> __Marshaller_protos_RequestTo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.RequestTo.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.Response> __Marshaller_protos_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.Response.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.PushRequest> __Marshaller_protos_PushRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.PushRequest.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.PushResponse> __Marshaller_protos_PushResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.PushResponse.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.KickRequest> __Marshaller_protos_KickRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.KickRequest.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.StartPitayaRequest> __Marshaller_protos_StartPitayaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.StartPitayaRequest.Parser));
    static readonly grpc::Marshaller<global::NPitaya.Protos.Error> __Marshaller_protos_Error = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NPitaya.Protos.Error.Parser));
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));

    static readonly grpc::Method<global::NPitaya.Protos.RPCResponse, global::NPitaya.Protos.SidecarRequest> __Method_ListenRPC = new grpc::Method<global::NPitaya.Protos.RPCResponse, global::NPitaya.Protos.SidecarRequest>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ListenRPC",
        __Marshaller_protos_RPCResponse,
        __Marshaller_protos_SidecarRequest);

    static readonly grpc::Method<global::NPitaya.Protos.RequestTo, global::NPitaya.Protos.Response> __Method_SendRPC = new grpc::Method<global::NPitaya.Protos.RequestTo, global::NPitaya.Protos.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendRPC",
        __Marshaller_protos_RequestTo,
        __Marshaller_protos_Response);

    static readonly grpc::Method<global::NPitaya.Protos.PushRequest, global::NPitaya.Protos.PushResponse> __Method_SendPush = new grpc::Method<global::NPitaya.Protos.PushRequest, global::NPitaya.Protos.PushResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendPush",
        __Marshaller_protos_PushRequest,
        __Marshaller_protos_PushResponse);

    static readonly grpc::Method<global::NPitaya.Protos.KickRequest, global::NPitaya.Protos.PushResponse> __Method_SendKick = new grpc::Method<global::NPitaya.Protos.KickRequest, global::NPitaya.Protos.PushResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendKick",
        __Marshaller_protos_KickRequest,
        __Marshaller_protos_PushResponse);

    static readonly grpc::Method<global::NPitaya.Protos.StartPitayaRequest, global::NPitaya.Protos.Error> __Method_StartPitaya = new grpc::Method<global::NPitaya.Protos.StartPitayaRequest, global::NPitaya.Protos.Error>(
        grpc::MethodType.Unary,
        __ServiceName,
        "StartPitaya",
        __Marshaller_protos_StartPitayaRequest,
        __Marshaller_protos_Error);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::NPitaya.Protos.Error> __Method_StopPitaya = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::NPitaya.Protos.Error>(
        grpc::MethodType.Unary,
        __ServiceName,
        "StopPitaya",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_protos_Error);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NPitaya.Protos.SidecarReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Sidecar</summary>
    [grpc::BindServiceMethod(typeof(Sidecar), "BindService")]
    public abstract partial class SidecarBase
    {
      public virtual global::System.Threading.Tasks.Task ListenRPC(grpc::IAsyncStreamReader<global::NPitaya.Protos.RPCResponse> requestStream, grpc::IServerStreamWriter<global::NPitaya.Protos.SidecarRequest> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::NPitaya.Protos.Response> SendRPC(global::NPitaya.Protos.RequestTo request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::NPitaya.Protos.PushResponse> SendPush(global::NPitaya.Protos.PushRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::NPitaya.Protos.PushResponse> SendKick(global::NPitaya.Protos.KickRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::NPitaya.Protos.Error> StartPitaya(global::NPitaya.Protos.StartPitayaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// AddRoute
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::NPitaya.Protos.Error> StopPitaya(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Sidecar</summary>
    public partial class SidecarClient : grpc::ClientBase<SidecarClient>
    {
      /// <summary>Creates a new client for Sidecar</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SidecarClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Sidecar that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SidecarClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SidecarClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SidecarClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::NPitaya.Protos.RPCResponse, global::NPitaya.Protos.SidecarRequest> ListenRPC(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenRPC(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::NPitaya.Protos.RPCResponse, global::NPitaya.Protos.SidecarRequest> ListenRPC(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ListenRPC, null, options);
      }
      public virtual global::NPitaya.Protos.Response SendRPC(global::NPitaya.Protos.RequestTo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendRPC(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::NPitaya.Protos.Response SendRPC(global::NPitaya.Protos.RequestTo request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendRPC, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Response> SendRPCAsync(global::NPitaya.Protos.RequestTo request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendRPCAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Response> SendRPCAsync(global::NPitaya.Protos.RequestTo request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendRPC, null, options, request);
      }
      public virtual global::NPitaya.Protos.PushResponse SendPush(global::NPitaya.Protos.PushRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendPush(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::NPitaya.Protos.PushResponse SendPush(global::NPitaya.Protos.PushRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendPush, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.PushResponse> SendPushAsync(global::NPitaya.Protos.PushRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendPushAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.PushResponse> SendPushAsync(global::NPitaya.Protos.PushRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendPush, null, options, request);
      }
      public virtual global::NPitaya.Protos.PushResponse SendKick(global::NPitaya.Protos.KickRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendKick(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::NPitaya.Protos.PushResponse SendKick(global::NPitaya.Protos.KickRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendKick, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.PushResponse> SendKickAsync(global::NPitaya.Protos.KickRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendKickAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.PushResponse> SendKickAsync(global::NPitaya.Protos.KickRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendKick, null, options, request);
      }
      public virtual global::NPitaya.Protos.Error StartPitaya(global::NPitaya.Protos.StartPitayaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StartPitaya(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::NPitaya.Protos.Error StartPitaya(global::NPitaya.Protos.StartPitayaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_StartPitaya, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Error> StartPitayaAsync(global::NPitaya.Protos.StartPitayaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StartPitayaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Error> StartPitayaAsync(global::NPitaya.Protos.StartPitayaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_StartPitaya, null, options, request);
      }
      /// <summary>
      /// AddRoute
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NPitaya.Protos.Error StopPitaya(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopPitaya(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AddRoute
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NPitaya.Protos.Error StopPitaya(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_StopPitaya, null, options, request);
      }
      /// <summary>
      /// AddRoute
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Error> StopPitayaAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopPitayaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// AddRoute
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NPitaya.Protos.Error> StopPitayaAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_StopPitaya, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SidecarClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SidecarClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SidecarBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListenRPC, serviceImpl.ListenRPC)
          .AddMethod(__Method_SendRPC, serviceImpl.SendRPC)
          .AddMethod(__Method_SendPush, serviceImpl.SendPush)
          .AddMethod(__Method_SendKick, serviceImpl.SendKick)
          .AddMethod(__Method_StartPitaya, serviceImpl.StartPitaya)
          .AddMethod(__Method_StopPitaya, serviceImpl.StopPitaya).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SidecarBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListenRPC, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::NPitaya.Protos.RPCResponse, global::NPitaya.Protos.SidecarRequest>(serviceImpl.ListenRPC));
      serviceBinder.AddMethod(__Method_SendRPC, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NPitaya.Protos.RequestTo, global::NPitaya.Protos.Response>(serviceImpl.SendRPC));
      serviceBinder.AddMethod(__Method_SendPush, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NPitaya.Protos.PushRequest, global::NPitaya.Protos.PushResponse>(serviceImpl.SendPush));
      serviceBinder.AddMethod(__Method_SendKick, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NPitaya.Protos.KickRequest, global::NPitaya.Protos.PushResponse>(serviceImpl.SendKick));
      serviceBinder.AddMethod(__Method_StartPitaya, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NPitaya.Protos.StartPitayaRequest, global::NPitaya.Protos.Error>(serviceImpl.StartPitaya));
      serviceBinder.AddMethod(__Method_StopPitaya, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::NPitaya.Protos.Error>(serviceImpl.StopPitaya));
    }

  }
}
#endregion
