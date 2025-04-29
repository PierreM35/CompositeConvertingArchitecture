using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class IntEncoder(byte bitNumber) : Coder<int>
    {
        private readonly byte _bitNumber = bitNumber;

        public override Code Encode(int value)
        {
            if (value > Math.Pow(2, _bitNumber) - 1)
                throw new ArgumentException($"Value {value} not convertible into {_bitNumber} bites");

            throw new NotImplementedException();
        }

        public override int Decode(Code code)
        {
            if (code.Length != _bitNumber)
                throw new ArgumentException($"Awaited code must have {_bitNumber} bits. Has {code.Length}.");

            throw new NotImplementedException();
        }
    }
}
