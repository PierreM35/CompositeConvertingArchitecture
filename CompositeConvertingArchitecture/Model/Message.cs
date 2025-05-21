using ModelDigitalisationArchitecture.Abstractions;

namespace ModelDigitalisationArchitecture.Model
{
    public class Message(byte standardVersion, byte containerId, Container container)
    {
        public byte StandardVersion => standardVersion;
        public byte ContainerId => containerId;
        public Container Container => container;
    }
}
