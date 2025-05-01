using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;
using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message : Encodable
    {
        private readonly byte _standardVersion;
        private readonly byte _containerId;
        private readonly Container _container;

        public Message(byte standardVersion, byte containerId, Container container)
        {
            _standardVersion = standardVersion;
            _container = container;
            _containerId = containerId;
        }

        public override Code Encode()
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(_standardVersion));

            var idEncoder = new IntCoder(4);
            code.Append(idEncoder.Encode(_containerId));

            code.Append(_container.Encode());

            return code;
        }
    }
}
