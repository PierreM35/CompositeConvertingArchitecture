using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
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
