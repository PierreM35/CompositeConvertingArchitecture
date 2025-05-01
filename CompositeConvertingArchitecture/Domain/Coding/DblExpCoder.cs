using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class DblExpCoder(byte bitNumberBase, byte bitNumberExp) : Coder<double>((byte)(bitNumberBase + bitNumberExp))
    {
        private readonly byte bitNumberBase = bitNumberBase;
        private readonly byte bitNumberExp = bitNumberExp;

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
