using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Parameter1(int value) : Parameter<int>(value, GetCoder())
    {
        public static Parameter1 FromCode(Code code) => new(code.Extract(GetCoder()));

        private static Coder<int> GetCoder() => new IntCoder(4);
    }
}
