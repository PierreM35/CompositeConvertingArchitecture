using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Parameter2(double value) : Parameter<double>(value, GetCoder())
    {
        public static Parameter2 FromCode(Code code) => new(code.Extract(GetCoder()));
        private static DblCoder GetCoder() => new(6);
    }
}
