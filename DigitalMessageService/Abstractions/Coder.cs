using DigitalMessageService.Model;

namespace DigitalMessageService.Abstractions
{
    public abstract class Coder<T>(byte bitsQuantity)
    {
        public byte BitsQuantity { get; } = bitsQuantity;

        public abstract Binary Encode(T value);
        public abstract T Decode(Binary value);
    }
}
