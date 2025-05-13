using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Parameter1(int value) : Parameter<int>(value, Coder)
    {
        public static Parameter1 FromCode(Code code) => new(code.Extract(Coder));

        private static Coder<int> Coder => new IntCoder(4);
    }
}
