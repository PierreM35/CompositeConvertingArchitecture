using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders
{
    public class IdCoder() : Coder<byte>(5)
    {
        public override byte Decode(Binary binary)
        {
            throw new NotImplementedException();
        }

        public override Binary Encode(byte value)
        {
            throw new NotImplementedException();
        }
    }
}
