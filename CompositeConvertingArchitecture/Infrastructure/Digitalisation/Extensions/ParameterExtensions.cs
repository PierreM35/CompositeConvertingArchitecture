using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions
{
    internal static class ParameterExtensions
    {
        public static Binary Encode(this Parameter1 parameter1) => Encode(parameter1.Value, new IntCoder(4));
        public static Binary Encode(this Parameter2 parameter2) => Encode(parameter2.Value, new DblCoder(6));
        public static Binary Encode(this Parameter3 parameter3) => Encode(parameter3.Value, new DblExpCoder(4, 3));

        private static Binary Encode<T>(T value, Coder<T> coder) => coder.Encode(value);
    }
}
