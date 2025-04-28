using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class DblCoder(byte bitNumber) : Coder<double>
    {
        private readonly byte _bitNumber = bitNumber;

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
