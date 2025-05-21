using ModelDigitalisationArchitecture.Domain.Abstractions;
using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace CompositeConvertingArchitectureTests.Utils
{
    internal class FakeMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(Binary code) => MessageReceived?.Invoke(this, Decode(code));

        private static Message Decode(Binary code)
        {
            var codingService = new CodingService();
            return codingService.Decode(code);
        }

        public void Send(Message message)
        {
            var codingService = new CodingService();
            var code = codingService.Encode(message);

            throw new NotImplementedException();        //send code using some process
        }
    }
}
