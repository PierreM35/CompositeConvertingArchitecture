using CompositeConvertingArchitecture.Domain.Abstractions;

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

        public override double Decode(string value)
        {
            throw new NotImplementedException();
        }

        public override string Encode(double value)
        {
            throw new NotImplementedException();
        }
    }
}
