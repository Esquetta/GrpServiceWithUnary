using Grpc.Core;
using gRPCExample;
using static gRPCExample.Message;

namespace GrpcServiceUnary.Services
{
    public class MessageService : MessageBase
    {
        public async override Task<MessageResponse> GetMessage(MessageRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Mesaj alınmıştır.");
            Console.WriteLine("Gelen mesaj : ");
            Console.WriteLine(request.Message);

            return new MessageResponse { Message = "İstek Alındı ve İşlendi" };
        }
    }
}
