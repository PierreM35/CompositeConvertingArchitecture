using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Enums;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Enum1(byte index, byte bitSize) : Enumeration(new ForEnum1(), index, bitSize)
    {
        public static Enum1 FromCode(Code code)
        {
            throw new NotImplementedException();
        }
    }
}
