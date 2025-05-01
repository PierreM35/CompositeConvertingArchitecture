
namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public class ContainerDescription(IEnumerable<Type> containedTypes, bool isMessagable)
    {
        public IEnumerable<Type> ContainedTypes { get; } = containedTypes;
        public bool IsMessagable { get; } = isMessagable;
    }
}
