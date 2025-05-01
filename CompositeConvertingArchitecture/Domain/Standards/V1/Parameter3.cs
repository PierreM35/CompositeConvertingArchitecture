using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter3(double value) : Parameter<double>(value, GetCoder())
    {
        public static Parameter3 FromCode(Code code) => new(code.Extract(GetCoder()));
        private static Coder<double> GetCoder() => new DblExpCoder(4, 3);
    }
}
