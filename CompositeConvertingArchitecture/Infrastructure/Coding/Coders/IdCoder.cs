using ModelDigitalisationArchitecture.Infrastructure.Coding.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Coders
{
    public class IdCoder() : Coder<byte>(5)
    {
        public override byte Decode(Code code)
        {
            throw new NotImplementedException();
        }

        public override Code Encode(byte value)
        {
            throw new NotImplementedException();
        }
    }
}
