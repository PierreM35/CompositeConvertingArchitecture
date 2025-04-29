
namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public class ContainerDescription(byte id, IEnumerable<Type> containedTypes, bool isMessagable)
    {
        public IEnumerable<Type> ContainedTypes { get; } = containedTypes;
        public bool IsMessagable { get; } = isMessagable;
        public byte Id { get; } = id;
    }
}
