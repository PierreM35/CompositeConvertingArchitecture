
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public interface ISender
    {
        public void Send(Message message);
    }
}
