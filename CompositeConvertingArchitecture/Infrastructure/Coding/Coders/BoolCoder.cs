using ModelDigitalisationArchitecture.Infrastructure.Coding.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Coders
{
    internal class BoolCoder() : Coder<bool>(1)
    {
        public override bool Decode(Code code) => code.Bits[0];
        public override Code Encode(bool value) => new(value);
    }
}