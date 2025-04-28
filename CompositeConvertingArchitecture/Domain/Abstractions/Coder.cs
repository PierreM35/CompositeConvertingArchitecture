
namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Coder<T>
    {
        public abstract string Encode(T value);
        public abstract T Decode(string value);
    }
}
