using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter2(double value) : Parameter<double>(value, GetCoder())
    {
        public static Parameter2 FromCode(Code code) => new(code.Extract(GetCoder()));
        private static DblCoder GetCoder() => new(6);
    }
}
