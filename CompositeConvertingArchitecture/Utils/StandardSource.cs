using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

namespace ModelDigitalisationArchitecture.Utils
{
    public static class StandardSource
    {
        public static IList<Standard> Standards { get; } = [new Standard1()];
    }
}
