using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture
{
    public static class StandardSource
    {
        public static IList<Standard> Standards { get; } = new List<Standard>();

    }
}
