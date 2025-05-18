using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Abstractions;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Coders;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Extensions
{
    internal static class ParameterExtensions
    {
        public static Code Encode(this Parameter1 parameter1) => Encode(parameter1.Value, new IntCoder(4));
        public static Code Encode(this Parameter2 parameter2) => Encode(parameter2.Value, new DblCoder(6));
        public static Code Encode(this Parameter3 parameter3) => Encode(parameter3.Value, new DblExpCoder(4, 3));

        private static Code Encode<T>(T value, Coder<T> coder) => coder.Encode(value);
    }
}
