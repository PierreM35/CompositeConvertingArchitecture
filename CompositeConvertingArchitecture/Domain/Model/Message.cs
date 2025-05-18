using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message(byte standardVersion, byte containerId, Container container)
    {
        public byte StandardVersion => standardVersion;
        public byte ContainerId => containerId;
        public Container Container => container;
    }
}
