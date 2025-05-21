using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;
using DigitalMessageService.Extensions;

namespace CompositeConvertingArchitectureTests.Utils
{
    internal class FakeMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(Binary binary) => MessageReceived?.Invoke(this, Decode(binary));

        private static Message Decode(Binary binary)
        {
            var codingService = new Factory(binary);
            return codingService.ExtractMessage();
        }

        public void Send(Message message)
        {
            var code = message.Encode();

            throw new NotImplementedException();        //send code using some process
        }
    }
}
