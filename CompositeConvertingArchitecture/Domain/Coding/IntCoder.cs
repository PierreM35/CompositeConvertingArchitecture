using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class IntCoder(byte bitNumber) : Coder<int>(bitNumber)
    {
        public override Code Encode(int value)
        {
            if (value > Math.Pow(2, BitsQuantity) - 1)
                throw new ArgumentException($"Value {value} not convertible into {BitsQuantity} bites");

            throw new NotImplementedException();
        }

        public override int Decode(Code code)
        {
            if (code.Length < BitsQuantity)
                throw new ArgumentException($"Awaited code must have {BitsQuantity} bits. Has {code.Length}.");

            throw new NotImplementedException();
        }
    }
}
