using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class DblExpCoder : Coder<double>
    {
        private readonly byte bitNumberBase;
        private readonly byte bitNumberExp;

        public DblExpCoder(byte bitNumberBase, byte bitNumberExp)
        {
            this.bitNumberBase = bitNumberBase;
            this.bitNumberExp = bitNumberExp;
        }

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
