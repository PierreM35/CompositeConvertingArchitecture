using CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Coders
{
    public class DblCoder(byte bitNumber) : Coder<double>(bitNumber)
    {
        public override double Decode(Code code)
        {
            throw new NotImplementedException();
        }

        public override Code Encode(double value)
        {
            throw new NotImplementedException();
        }
    }
}
