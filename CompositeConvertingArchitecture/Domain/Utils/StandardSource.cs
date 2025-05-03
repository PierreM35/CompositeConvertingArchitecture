using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Standards;

namespace CompositeConvertingArchitecture.Domain.Utils
{
    public static class StandardSource
    {
        public static IList<Standard> Standards { get; } = [new Standard1()];

    }
}
