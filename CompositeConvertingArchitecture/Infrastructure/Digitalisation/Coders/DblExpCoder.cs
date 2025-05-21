using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders
{
    public class DblExpCoder(byte bitNumberBase, byte bitNumberExp) : Coder<double>((byte)(bitNumberBase + bitNumberExp))
    {
        public override double Decode(Binary code)
        {
            throw new NotImplementedException();
        }

        public override Binary Encode(double value)
        {
            throw new NotImplementedException();
        }
    }
}
