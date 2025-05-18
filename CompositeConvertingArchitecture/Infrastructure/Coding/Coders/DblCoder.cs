using ModelDigitalisationArchitecture.Infrastructure.Coding.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Coders
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
