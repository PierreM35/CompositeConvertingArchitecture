using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions
{
    public abstract class Coder<T>(byte bitsQuantity)
    {
        public byte BitsQuantity { get; } = bitsQuantity;

        public abstract Code Encode(T value);
        public abstract T Decode(Code value);
    }
}
