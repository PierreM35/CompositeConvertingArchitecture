using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

namespace DigitalMessageService
{
    public class DigitalMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
