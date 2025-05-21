using Grpc.Net.Client;
using GrpcMessageService.Services;
using ModelDigitalisationArchitecture.Domain.Abstractions;

namespace GrpcMessageService
{
    public class GrpcMessageService : IMessageService
    {
        private MessagerService _messageService;


        public GrpcMessageService()
        {
            _messageService = new MessagerService();
            _messageService.MessageReceived += MessageReceived;
        }

        public event EventHandler<ModelDigitalisationArchitecture.Domain.Model.Message> MessageReceived;

        public void Send(ModelDigitalisationArchitecture.Domain.Model.Message message)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7196/");
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
