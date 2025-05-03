using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Standards.V1.Enums;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Enum1(byte index, byte bitSize) : Enumeration(new EnumName(), index, bitSize)
    {
        public static Enum1 FromCode(Code code)
        {
            throw new NotImplementedException();
        }
    }
}
