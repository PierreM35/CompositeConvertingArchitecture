using ModelDigitalisationArchitecture.Domain.Abstractions;
using ModelDigitalisationArchitecture.Domain.Model;

namespace ModelDigitalisationArchitecture.Infrastructure
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
