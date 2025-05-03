using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public interface IMessageService
    {
        void Send(Message message);
        event EventHandler<Message> MessageReceived;
    }
}
