using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message(byte standardVersion, byte containerId, Container container) : Encodable
    {
        public byte StandardVersion { get; } = standardVersion;
        public byte ContainerId { get; } = containerId;
        public Container Container { get; } = container;

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
