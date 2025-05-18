using CompositeConvertingArchitecture.Infrastructure.Coding.Abstractions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Coders
{
    internal class BoolCoder() : Coder<bool>(1)
    {
        public override bool Decode(Code code) => code.Bits[0];
        public override Code Encode(bool value) => new(value);
    }
}