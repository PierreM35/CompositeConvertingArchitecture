using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Standards.V1.Enums;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class SomeEnum(byte index, byte bitSize) : Enumeration(new EnumName(), index, bitSize)
    {
    }
}
