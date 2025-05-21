using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
{
    internal class BoolCoder() : Coder<bool>(1)
    {
        public override bool Decode(Binary binary) => binary.Bits[0];
        public override Binary Encode(bool value) => new(value);
    }
}