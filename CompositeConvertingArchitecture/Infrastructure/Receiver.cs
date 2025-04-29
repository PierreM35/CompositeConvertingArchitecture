using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Domain.Standards;

namespace CompositeConvertingArchitecture.Infrastructure
{
    public class Receiver : IReceiver
    {
        public event EventHandler<Message> MessageReceived;

        public void Receive(string text) => MessageReceived?.Invoke(this, Decode(text));      //for testing

        private static Message Decode(string text)
        {
            var code = new Code(text);

            var stdVersion = code.ExtractStandardVersion();
            var standard = StandardSource.Standards[stdVersion];
            
            var containerId = code.ExtractContainerId();

            return new Message(stdVersion, standard.Decode(code, containerId));
        }
    }
}
