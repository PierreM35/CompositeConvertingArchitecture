using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;
using DigitalMessageService.Extensions;

namespace DigitalMessageServiceTests.Utils
{
    internal class FakeMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(Binary binary) => MessageReceived?.Invoke(this, Decode(binary));

        private static Message Decode(Binary binary)
        {
            var factory = new Factory(binary);
            return factory.ExtractMessage();
        }

        public void Send(Message message) 
        {
            var binary = message.Encode();

            throw new NotImplementedException();        //send code using some process
        }
    }
}
