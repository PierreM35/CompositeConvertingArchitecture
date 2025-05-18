using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Enums;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Coders;
using CompositeConvertingArchitecture.Infrastructure.Coding.Extensions;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Model
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

        public byte ExtractStandardVersion() => Extract(new StdVersionCoder());
        public byte ExtractContainerId() => Extract(new IdCoder());

        public Container ExtractContainer(Type containerType)
        {
            if (containerType == typeof(Container1))
                return ExtractContainer1();

            if (containerType == typeof(Container2))
                return ExtractContainer2();

            throw new NotImplementedException($"{containerType} not implemented yet.");
        }

        #region Private helpers

        private Container1 ExtractContainer1()
        {
            var param1 = ExtractParameter1();
            var param2 = ExtractParameter2();
            var param3 = ExtractParameter3();
            var escaper = ExtractEscaper();
            var container2 = escaper.Keep ? ExtractContainer2() : null;
            var enum1 = ExtractEnum1();

            return new Container1(param1, param2, param3, enum1, container2);
        }

        private Container2 ExtractContainer2()
        {
            var param2 = ExtractParameter2();
            var param3s = new List<Parameter3>();
            var repeater = ExtractRepeater();
            if (repeater.Repeat)
            {
                do
                {
                    param3s.Add(ExtractParameter3());
                    repeater = ExtractRepeater();
                } while (repeater.Repeat);
            }
            var enum1 = ExtractEnum1();

            return new Container2(param2, param3s, enum1);
        }

        private Enum1 ExtractEnum1() => (Enum1)Extract(new ByteCoder(3));
        private Parameter1 ExtractParameter1() => new(Extract(new IntCoder(4)));
        private Parameter2 ExtractParameter2() => new(Extract(new DblCoder(6)));
        private Parameter3 ExtractParameter3() => new(Extract(new DblExpCoder(4, 3)));
        private Escaper ExtractEscaper() => new(Extract(new BoolCoder()));
        private Repeater ExtractRepeater() => new(Extract(new BoolCoder()));
        private T Extract<T>(Coder<T> coder) => coder.Decode(Cut(coder.BitsQuantity));
        private Code Cut(byte quantity) => new(_bits.Dequeue(quantity));

        #endregion
    }
}
