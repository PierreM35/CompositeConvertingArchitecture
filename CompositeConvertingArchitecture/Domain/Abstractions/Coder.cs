
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Coder<T>
    {
        public abstract Code Encode(T value);
        public abstract T Decode(Code value);
    }
}
