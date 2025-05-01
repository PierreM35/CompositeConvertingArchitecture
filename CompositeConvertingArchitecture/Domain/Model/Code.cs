using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Extensions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Code
    {
        private readonly Queue<bool> bits;

        public int Length => bits.Count;
        public bool[] Bits => [.. bits];

        public Code()
        {
            bits = new Queue<bool>();
        }

        public Code(bool bit) : this()
        {
            bits.Enqueue(bit);
        }

        public Code(IEnumerable<bool> bits)
        {
            this.bits = new(bits);
        }

        public T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));

        public void Append(Code code) => bits.Enqueue(code.bits);

        private Code Cut(byte quantity) => new(bits.Dequeue(quantity));
    }
}
