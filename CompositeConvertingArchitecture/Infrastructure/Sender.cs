using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Infrastructure
{
    public class Sender : ISender
    {
        public void Send(Message message)
        {
            var code = message.Encode();

            throw new NotImplementedException();
        }
    }
}
