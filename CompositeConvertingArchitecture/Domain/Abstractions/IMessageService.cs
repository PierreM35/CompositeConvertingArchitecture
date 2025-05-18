using ModelDigitalisationArchitecture.Domain.Model;

namespace ModelDigitalisationArchitecture.Domain.Abstractions
{
    public interface IMessageService
    {
        void Send(Message message);
        event EventHandler<Message> MessageReceived;
    }
}
