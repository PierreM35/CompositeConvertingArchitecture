
namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public class ContainerDescription(Type containerType, IEnumerable<Type> containedTypes, bool isMessagable)
    {
        public Type ContainerType { get; } = containerType;
        public IEnumerable<Type> ContainedTypes { get; } = containedTypes;
        public bool IsMessagable { get; } = isMessagable;
    }
}
