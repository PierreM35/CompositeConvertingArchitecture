using DigitalMessageService.Extensions;
using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

namespace DigitalMessageService
{
    public class DigitalMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Send(Message message)
        {
            var binary = message.Encode();

            throw new NotImplementedException();
        }

        private void OnBinaryReceived(Binary binary)
        {
            var factory = new Factory(binary);
            var message = factory.ExtractMessage();
            MessageReceived?.Invoke(this, message);
        }
    }
}
