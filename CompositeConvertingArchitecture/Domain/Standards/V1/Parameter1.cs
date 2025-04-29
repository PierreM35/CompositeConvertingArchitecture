using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter1(int value) : Parameter<int>(value, new IntEncoder(4))
    {
    }
}
