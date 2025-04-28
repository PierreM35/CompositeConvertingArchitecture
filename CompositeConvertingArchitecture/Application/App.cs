using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Application
{
    public class App
    {
        public ISender Sender { get; }
        public IReceiver Receiver { get; }

        public App(ISender sender, IReceiver receiver)
        {
            Sender = sender;
            Receiver = receiver;
            receiver.MessageReceived += OnMessageReceived;
        }

        private void OnMessageReceived(object? sender, Message message)
        {
            throw new NotImplementedException();
        }
    }
}
