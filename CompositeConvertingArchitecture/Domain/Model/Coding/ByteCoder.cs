using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model.Coding
{
    public class ByteCoder(byte bitNumber) : Coder<byte>(bitNumber)
    {
        public override Code Encode(byte value)
        {
            if (value > Math.Pow(2, BitsQuantity) - 1)
                throw new ArgumentException($"Value {value} not convertible into {BitsQuantity} bites");

            throw new NotImplementedException();
        }

        public override byte Decode(Code code)
        {
            if (code.Length != BitsQuantity)
                throw new ArgumentException($"Awaited code must have {BitsQuantity} bits. Has {code.Length}.");

            throw new NotImplementedException();
        }
    }
}
