using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Standards.V1
{
    public class SomeEnum(byte index, byte bitSize) : Enumeration(new EnumName(), index, bitSize)
    {
    }


    public enum EnumName
    {
        a, b, c, d
    }
}
