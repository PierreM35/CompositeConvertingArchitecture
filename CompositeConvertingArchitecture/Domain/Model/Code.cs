using CompositeConvertingArchitecture.Domain.Coding;
using CompositeConvertingArchitecture.Domain.Extensions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Code
    {
        private readonly Queue<bool> bits;

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

        public int Length => bits.Count;

        public Escaper ExtractEscaper() => new(bits.Dequeue());

        public byte ExtractStandardVersion()
        {
            var decoder = new StdVersionCoder();
            return decoder.Decode(Extract(StdVersionCoder.StandardVersionBitsNb));
        }

        public byte ExtractContainerId()
        {
            var decoder = new IdCoder();
            return decoder.Decode(Extract(IdCoder.IdBitsNb));
        }

        public void Append(Code code)
        {
            for (int i = 0; i < code.bits.Count; i++) 
                bits.Enqueue(code.bits.Peek());
        }

        private Code Extract(byte quantity) => new(bits.Dequeue(quantity));
    }
}
