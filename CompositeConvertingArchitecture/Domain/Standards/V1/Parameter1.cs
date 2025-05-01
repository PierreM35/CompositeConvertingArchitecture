using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter1(int value) : Parameter<int>(value, GetCoder())
    {
        public static Parameter1 FromCode(Code code) => new(code.Extract(GetCoder()));
        private static IntCoder GetCoder() => new(4);
    }
}
