using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Parameter3(double value) : Parameter<double>(value, GetCoder())
    {
        public static Parameter3 FromCode(Code code) => new(code.Extract(GetCoder()));
        private static Coder<double> GetCoder() => new DblExpCoder(4, 3);
    }
}
