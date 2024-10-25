// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac_autumn.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ZodiacService.Protos {
  public static partial class ZodiacSignTellerAutumn
  {
    static readonly string __ServiceName = "zodiac.ZodiacSignTellerAutumn";

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

    static readonly grpc::Marshaller<global::ZodiacService.Protos.DateRequestAutumn> __Marshaller_zodiac_DateRequestAutumn = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacService.Protos.DateRequestAutumn.Parser));
    static readonly grpc::Marshaller<global::ZodiacService.Protos.ZodiacSignAutumn> __Marshaller_zodiac_ZodiacSignAutumn = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ZodiacService.Protos.ZodiacSignAutumn.Parser));

    static readonly grpc::Method<global::ZodiacService.Protos.DateRequestAutumn, global::ZodiacService.Protos.ZodiacSignAutumn> __Method_SayZodiacSign = new grpc::Method<global::ZodiacService.Protos.DateRequestAutumn, global::ZodiacService.Protos.ZodiacSignAutumn>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayZodiacSign",
        __Marshaller_zodiac_DateRequestAutumn,
        __Marshaller_zodiac_ZodiacSignAutumn);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ZodiacService.Protos.ZodiacAutumnReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ZodiacSignTellerAutumn</summary>
    public partial class ZodiacSignTellerAutumnClient : grpc::ClientBase<ZodiacSignTellerAutumnClient>
    {
      /// <summary>Creates a new client for ZodiacSignTellerAutumn</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZodiacSignTellerAutumnClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZodiacSignTellerAutumn that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZodiacSignTellerAutumnClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZodiacSignTellerAutumnClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZodiacSignTellerAutumnClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ZodiacService.Protos.ZodiacSignAutumn SayZodiacSign(global::ZodiacService.Protos.DateRequestAutumn request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayZodiacSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ZodiacService.Protos.ZodiacSignAutumn SayZodiacSign(global::ZodiacService.Protos.DateRequestAutumn request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayZodiacSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacService.Protos.ZodiacSignAutumn> SayZodiacSignAsync(global::ZodiacService.Protos.DateRequestAutumn request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayZodiacSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ZodiacService.Protos.ZodiacSignAutumn> SayZodiacSignAsync(global::ZodiacService.Protos.DateRequestAutumn request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayZodiacSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZodiacSignTellerAutumnClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZodiacSignTellerAutumnClient(configuration);
      }
    }

  }
}
#endregion
