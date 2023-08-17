using Grpc.Net.Client;
using gRPCExample;

namespace GrpcClientUnary
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                var channel = GrpcChannel.ForAddress("http://localhost:5105");
                var messageClient = new Message.MessageClient(channel);
                Console.WriteLine("Lütfen gönderilecek mesajı giriniz.");
                var messageResponse = await messageClient.GetMessageAsync(new MessageRequest { Message = Console.ReadLine() });
                await Console.Out.WriteLineAsync($"Cevap: "+messageResponse);
            }
        }
    }
}
