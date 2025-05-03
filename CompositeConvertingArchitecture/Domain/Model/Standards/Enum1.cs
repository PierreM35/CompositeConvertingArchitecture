using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Enums;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Enum1(byte index) : Enumeration(new ForEnum1(), index, _bitSize)
    {
        private static readonly byte _bitSize = 3;

        public static Enum1 FromCode(Code code)
        {
            var coder = new ByteCoder(_bitSize);

            return new Enum1(code.Extract(coder));
        }
    }
}
