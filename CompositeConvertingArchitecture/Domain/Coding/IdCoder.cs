using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Coding
{
    public class IdCoder() : Coder<byte>(5)
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
