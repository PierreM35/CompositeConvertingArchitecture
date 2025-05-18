using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders
{
    internal class BoolCoder() : Coder<bool>(1)
    {
        public override bool Decode(Code code) => code.Bits[0];
        public override Code Encode(bool value) => new(value);
    }
}