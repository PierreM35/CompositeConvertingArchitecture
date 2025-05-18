using CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Coders
{
    public class StdVersionCoder() : Coder<byte>(4)
    {
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
