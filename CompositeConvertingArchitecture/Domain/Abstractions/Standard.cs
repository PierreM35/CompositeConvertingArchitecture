using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(int id, IEnumerable<KeyValuePair<Type, ContainerDescription>?> containerDescriptions)
    {
        public int Id { get; } = id;
        public IEnumerable<KeyValuePair<Type, ContainerDescription>?> ContainerDescriptions { get; } = containerDescriptions;

        public Container Decode(Code code, int containerId)
        {
            var containerDescription = ContainerDescriptions
                .Where(kvp => kvp.Value.Value.Id == containerId)
                .FirstOrDefault();

            if (containerDescription == null)
                throw new InvalidOperationException($"No container with Id {containerId} is registered in Standard {Id}");

            var containedTypes = containerDescription.Value.Value.ContainedTypes;
            foreach (var containedType in containedTypes)
            {
                if (containedType.Equals(typeof(Escaper)))

            }
        }
    }
}
