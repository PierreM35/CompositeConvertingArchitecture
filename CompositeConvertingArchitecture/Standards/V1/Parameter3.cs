using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Standards.V1
{
    public class Parameter3(double value) : Parameter<double>(value, new DblExpCoder(4, 3))
    {
    }
}
