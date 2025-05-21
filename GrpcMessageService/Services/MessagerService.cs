using Grpc.Core;
using GrpcMessageService;

namespace GrpcMessageService.Services
{
    public class MessagerService : Messager.MessagerBase
    {
        //private readonly ILogger<MessagerService> _logger;

        public MessagerService()
        {
            //_logger = logger;
        }

        public event EventHandler<ModelDigitalisationArchitecture.Model.Message> MessageReceived;
      
        public override Task<MessageSent> SendMessage(Message request, ServerCallContext context)
        {
            MessageReceived?.Invoke(null, new ModelDigitalisationArchitecture.Model.Message(
                (byte)request.StandardId,
                (byte)request.ContainerId,
                null));

            return Task.FromResult(new MessageSent
            {
                IsMessageSent = true
            });
        }
    }
}
