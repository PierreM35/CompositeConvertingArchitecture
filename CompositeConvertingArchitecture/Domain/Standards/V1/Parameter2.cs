using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter2(double value) : Parameter<double>(value, new DblCoder(6))
    {
    }
}
