
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public interface IReceiver
    {
        event EventHandler<Message> MessageReceived;
    }
}
