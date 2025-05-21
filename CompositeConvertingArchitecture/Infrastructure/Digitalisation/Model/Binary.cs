using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model
{
    public class Binary
    {
        private readonly Queue<bool> _bits;

        public int Length => _bits.Count;
        public bool[] Bits => [.. _bits];

        public Binary() => _bits = new Queue<bool>();
        public Binary(bool bit) : this() => _bits.Enqueue(bit);
        public Binary(IEnumerable<bool> bits) => _bits = new(bits);

        public void Append(Binary binary) => _bits.Enqueue(binary._bits);
        public T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));

        private Binary Cut(byte quantity) => new(_bits.Dequeue(quantity));
    }
}
