using ModelDigitalisationArchitecture.Domain.Abstractions;
using ModelDigitalisationArchitecture.Domain.Model;

namespace ModelDigitalisationArchitecture.Domain.Utils
{
    public static class StandardSource
    {
        public static IList<Standard> Standards { get; } = [new Standard1()];
    }
}
