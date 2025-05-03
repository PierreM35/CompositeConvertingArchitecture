using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message : Encodable
    {
        public byte StandardVersion { get; }
        public byte ContainerId { get; }
        public Container Container { get; }

        public Message(byte standardVersion, byte containerId, Container container)
        {
            StandardVersion = standardVersion;
            Container = container;
            ContainerId = containerId;
        }

        public override Code Encode()
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(StandardVersion));

            var idEncoder = new IntCoder(4);
            code.Append(idEncoder.Encode(ContainerId));

            code.Append(Container.Encode());

            return code;
        }
    }
}
