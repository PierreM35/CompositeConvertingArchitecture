using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(int id, IDictionary<Type, ContainerDescription> containerDescriptions)
    {
        public int Id { get; } = id;
        public IDictionary<Type, ContainerDescription> ContainerDescriptions { get; } = containerDescriptions;

        public Container Decode(Code code, int containerId)
        {
            var containerDescription = ContainerDescriptions
                .Where(kvp => kvp.Value.Id == containerId)
                .FirstOrDefault();

            if (containerDescription.Equals(default(KeyValuePair<Type, ContainerDescription>)))
                throw new InvalidOperationException($"No container with Id {containerId} is registered in Standard {Id}");

            var containedTypes = containerDescription.Value.ContainedTypes;
            foreach (var containedType in containedTypes)
            {
                if (containedType.Equals(typeof(Escaper)))
                {
                    var escapre = code.ExtractEscaper();
                }

                if (containedType)
                {

                }
            }
        }
    }
}
