using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
{
    public class DblCoder(byte bitNumber) : Coder<double>(bitNumber)
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
