using ModelDigitalisationArchitecture.Model;

namespace ModelDigitalisationArchitecture.Abstractions
{
    public interface IMessageService
    {
        void Send(Message message);
        event EventHandler<Message> MessageReceived;
    }
}
