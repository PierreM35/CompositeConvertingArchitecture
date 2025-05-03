using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Model.Coding
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
