using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Coding
{
    public class StdVersionCoder : Coder<byte>
    {
        public static byte StandardVersionBitsNb { get; } = 4;
        
        public override byte Decode(Code code)
        {
            throw new NotImplementedException();
        }

        public override Code Encode(byte value)
        {
            throw new NotImplementedException();
        }
    }
}
