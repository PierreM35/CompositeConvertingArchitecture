using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Infrastructure
{
    public class MessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;
        public void Send(Message message)
        {

            throw new NotImplementedException();
        }
    }
}
