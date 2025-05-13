using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Parameter2(double value) : Parameter<double>(value, Coder)
    {
        public static Parameter2 FromCode(Code code) => new(code.Extract(Coder));

        private static DblCoder Coder => new(6);
    }
}
