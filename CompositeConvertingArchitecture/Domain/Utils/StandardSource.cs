using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Utils
{
    public static class StandardSource
    {
        public static IList<Standard> Standards { get; } = new List<Standard>();

    }
}
