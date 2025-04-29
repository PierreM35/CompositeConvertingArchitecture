
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Encodable()
    {
        public abstract Code Encode();
    }
}
