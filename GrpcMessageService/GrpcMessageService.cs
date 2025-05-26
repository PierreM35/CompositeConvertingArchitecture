using Grpc.Net.Client;
//using GrpcMessageService.Services;
using ModelDigitalisationArchitecture.Abstractions;

namespace GrpcMessageService
{
    public class GrpcMessageService : IMessageService
    {
        //private MessagerService _messageService;


        public GrpcMessageService()
        {
            //_messageService = new MessagerService();
            //_messageService.MessageReceived += MessageReceived;


        }

        public event EventHandler<ModelDigitalisationArchitecture.Model.Message> MessageReceived;

        public void Send(ModelDigitalisationArchitecture.Model.Message message)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7031/");
            //var channel = GrpcChannel.ForAddress("https://localhost:5000/");
            var client = new Messager.MessagerClient(channel);
            var reply = client.SendMessage(new Message
            {
                StandardId = message.StandardVersion,
                ContainerId = message.ContainerId
            });

            //HasSentMessage?.Invoke(null, reply.IsMessageSent);

            //var grpcMessage = new Message
            //{
            //    ContainerId = message.ContainerId,
            //    StandardId = message.StandardVersion
            //};

            //SendMessage(grpcMessage, new ServerCallContext());
        }
    }
}
