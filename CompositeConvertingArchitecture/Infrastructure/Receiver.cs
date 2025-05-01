using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Domain.Standards;

namespace CompositeConvertingArchitecture.Infrastructure
{
    public class Receiver : IReceiver
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(bool[] bits) => MessageReceived?.Invoke(this, Decode(bits));      //for testing

        private static Message Decode(bool[] bits)
        {
            var code = new Code(bits);
            var stdVersion = code.Extract(new StdVersionCoder());
            var standard = StandardSource.Standards[stdVersion];

            var coder = new IdCoder();
            
            return new Message(
                stdVersion, 
                code.Extract(coder), 
                standard.Decode(code, code.Extract(coder)));
        }
    }
}
