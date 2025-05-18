using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Abstractions
{
    public abstract class Coder<T>(byte bitsQuantity)
    {
        public byte BitsQuantity { get; } = bitsQuantity;

        public abstract Code Encode(T value);
        public abstract T Decode(Code value);
    }
}
