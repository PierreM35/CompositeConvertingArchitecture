using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Domain.Model.Coding;
using CompositeConvertingArchitecture.Domain.Utils;

namespace CompositeConvertingArchitectureTests.Utils
{
    internal class FakeMessageService : IMessageService
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(Code code) => MessageReceived?.Invoke(this, Decode(code));

        private static Message Decode(Code code)
        {
            var stdVersion = code.Extract(new StdVersionCoder());
            var standard = StandardSource.Standards[stdVersion];

            var coder = new IdCoder();

            return new Message(
                stdVersion,
                code.Extract(coder),
                standard.Decode(code, code.Extract(coder)));
        }

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
