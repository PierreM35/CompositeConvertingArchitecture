using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Standards;
using System.Text;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message : Encodable
    {
        private readonly byte _standardVersion;
        private readonly byte _containerId;
        private readonly Container _container;

        public Message(byte standardVersion, Container container)
        {
            if (!StandardSource.Standards[standardVersion].MessagableContainers.Contains(container.GetType()))
                throw new ArgumentException("Message not sendable!");

            _standardVersion = standardVersion;
            _container = container;
            _containerId = (byte)StandardSource.Standards[standardVersion].MessagableContainers.IndexOf(container.GetType());
        }

        public override string Encode()
        {
            var code = new StringBuilder();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(_standardVersion));

            var idEncoder = new IntEncoder(4);
            code.Append(idEncoder.Encode(_containerId));

            code.Append(_container.Encode());

            return code.ToString();
        }
    }
}
