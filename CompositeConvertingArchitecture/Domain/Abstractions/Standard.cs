using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(int id, IDictionary<byte, ContainerDescription> containerDescriptions)
    {
        public int Id { get; } = id;
        protected IDictionary<byte, ContainerDescription> ContainerDescriptions { get; } = containerDescriptions;

        public abstract Container Decode(Code code, byte containerId);
    }
}
