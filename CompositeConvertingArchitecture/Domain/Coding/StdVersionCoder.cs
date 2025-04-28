using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Coding
{
    public class StdVersionCoder : Coder<byte>
    {
        public static byte StandardVersionBitsNb { get; } = 4;
        
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
