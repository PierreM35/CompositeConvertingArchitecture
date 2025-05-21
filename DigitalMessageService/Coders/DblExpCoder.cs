using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
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
