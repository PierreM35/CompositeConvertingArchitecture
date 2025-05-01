using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Coding
{
    internal class BoolCoder() : Coder<bool>(1)
    {
        public override bool Decode(Code code) => code.Bits[0];
        public override Code Encode(bool value) => new(value);
    }
}