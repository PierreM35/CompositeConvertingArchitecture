
namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public class ContainerDescription(int id, IEnumerable<Type> containedTypes, bool isMessagable)
    {
        public IEnumerable<Type> ContainedTypes { get; } = containedTypes;
        public bool IsMessagable { get; } = isMessagable;
        public int Id { get; } = id;
    }
}
