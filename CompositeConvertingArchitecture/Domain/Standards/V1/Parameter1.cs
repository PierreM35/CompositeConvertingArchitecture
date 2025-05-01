using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Parameter1 : Parameter<int>
    {
        public Parameter1(int value) : base(value, GetCoder())
        {
        }

        public Parameter1(Code code) : base(code.Extract(GetCoder()), GetCoder())
        {
        }

        public static IntCoder GetCoder() => new(4);
    }
}
