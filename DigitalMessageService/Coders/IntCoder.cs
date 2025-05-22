using DigitalMessageService.Abstractions;
using DigitalMessageService.Model;

namespace DigitalMessageService.Coders
{
    public class IntCoder(byte bitNumber) : Coder<int>(bitNumber)
    {
        public override Binary Encode(int value)
        {
            if (value > Math.Pow(2, BitsQuantity) - 1)
                throw new ArgumentException($"Value {value} not convertible into {BitsQuantity} bites");

            throw new NotImplementedException();
        }

        public override int Decode(Binary binary)
        {
            if (binary.Length < BitsQuantity)
                throw new ArgumentException($"Awaited binary must have {BitsQuantity} bits. Has {binary.Count}.");

            throw new NotImplementedException();
        }
    }
}
