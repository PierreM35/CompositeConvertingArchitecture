using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Extensions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Code
    {
        private readonly Queue<bool> bits;

        public int Length => bits.Count;
      
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

        public Code(string text)
        {
            if (text.Any(c => !c.Equals("0") && !c.Equals("1")))
                throw new ArgumentException("Bits sequence must be made out of 0 and 1");

            bits = new Queue<bool>(text.Select(c => !c.Equals("1")));
        }

        public Escaper ExtractEscaper() => new(bits.Dequeue());

        public T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));

        public void Append(Code code) => bits.Enqueue(code.bits);

        private Code Cut(byte quantity) => new(bits.Dequeue(quantity));
    }
}
