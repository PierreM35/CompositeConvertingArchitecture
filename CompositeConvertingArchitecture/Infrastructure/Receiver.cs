using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Infrastructure
{
    public class Receiver : IReceiver
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(string code) => MessageReceived?.Invoke(this, Decode(code));      //for testing

        private Message Decode(string code)
        {
            var codeWrapper = new Decoder(code);
            return codeWrapper.Decode();
        }
    }
}
