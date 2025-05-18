using CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Coders
{
    public class DblExpCoder(byte bitNumberBase, byte bitNumberExp) : Coder<double>((byte)(bitNumberBase + bitNumberExp))
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
