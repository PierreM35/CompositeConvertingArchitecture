namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(List<(Type, IEnumerable<Type>, byte?)> containers, Dictionary<Type, byte> sizes)
    {
        public List<(Type, IEnumerable<Type>, byte?)> Containers { get; } = containers;
        public Dictionary<Type, byte> Sizes { get; } = sizes;
    }
}
