using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(int id, Dictionary<byte, Func<Code, Container>> factoryMethodes)
    {      
        public int Id { get; } = id;
        //protected IDictionary<byte, ContainerDescription> ContainerDescriptions { get; } = containerDescriptions;

        public Container Decode(Code code, byte containerId)
        {
            if (!factoryMethodes.ContainsKey(containerId))
                throw new InvalidOperationException($"No container with Id {containerId} is registered in Standard version {Id}");

            return factoryMethodes[containerId].Invoke(code);
        }
    }
}
