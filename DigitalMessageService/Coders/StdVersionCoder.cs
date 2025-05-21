using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
{
    public class StdVersionCoder() : Coder<byte>(4)
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
