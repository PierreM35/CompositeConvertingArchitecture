using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Infrastructure.Coding;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitectureTests.Utils
{
    internal class FakeMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(Code code) => MessageReceived?.Invoke(this, Decode(code));

        private static Message Decode(Code code)
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
