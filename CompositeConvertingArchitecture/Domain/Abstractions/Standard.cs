using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Standard(byte id, Dictionary<byte, Func<Code, Container>> factoryMethods)
    {      
        public byte Id { get; } = id;

        public Container Decode(Code code, byte containerId)
        {
            if (!factoryMethods.ContainsKey(containerId))
                throw new InvalidOperationException($"No container with Id {containerId} is registered in Standard version {Id}");

            return factoryMethods[containerId].Invoke(code);
        }
    }
}
