using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Encoding
{
    public class IntEncoder(byte bitNumber) : Coder<int>
    {
        private readonly byte _bitNumber = bitNumber;

        public override string Encode(int value)
        {
            if (value > Math.Pow(2, _bitNumber) - 1)
                throw new ArgumentException($"Value {value} not convertible into {_bitNumber} bites");

            throw new NotImplementedException();
        }

        public override int Decode(string code)
        {
            if (code.Length != _bitNumber)
                throw new ArgumentException($"Awaited code must have {_bitNumber} bits. Has {code.Length}.");

            throw new NotImplementedException();
        }
    }
}
