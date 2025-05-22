using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Model;
using DigitalMessageService.Coders;
using DigitalMessageService.Abstractions;

namespace DigitalMessageService.Extensions
{
    internal static class ParameterExtensions
    {
        public static Binary Encode(this Parameter1 parameter1) => Encode(parameter1.Value, CoderGetter.ForParameter1());
        public static Binary Encode(this Parameter2 parameter2) => Encode(parameter2.Value, CoderGetter.ForParameter2());
        public static Binary Encode(this Parameter3 parameter3) => Encode(parameter3.Value, CoderGetter.ForParameter3());

        private static Binary Encode<T>(T value, Coder<T> coder) => coder.Encode(value);
    }
}
