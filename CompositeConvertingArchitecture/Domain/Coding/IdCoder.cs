
using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Coding
{
    public class IdCoder : Coder<byte>
    {
        public static byte IdBitsNb { get; } = 5;

        public override byte Decode(string value)
        {
            throw new NotImplementedException();
        }

        public override string Encode(byte value)
        {
            throw new NotImplementedException();
        }
    }
}
