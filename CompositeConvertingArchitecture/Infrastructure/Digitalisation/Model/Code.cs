using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model
{
    public class Code
    {
        private readonly Queue<bool> _bits;

        public int Length => _bits.Count;
        public bool[] Bits => [.. _bits];

        public Code() => _bits = new Queue<bool>();
        public Code(bool bit) : this() => _bits.Enqueue(bit);
        public Code(IEnumerable<bool> bits) => _bits = new(bits);

        public void Append(Code code) => _bits.Enqueue(code._bits);
        public T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));

        private Code Cut(byte quantity) => new(_bits.Dequeue(quantity));
    }
}
