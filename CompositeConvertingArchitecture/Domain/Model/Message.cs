using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;
using CompositeConvertingArchitecture.Domain.Encoding;
using CompositeConvertingArchitecture.Domain.Standards;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message : Encodable
    {
        private readonly byte _standardVersion;
        private readonly byte _containerId;
        private readonly Container _container;

        public Message(byte standardVersion, Container container)
        {
            var standard = StandardSource.Standards[standardVersion];
            var keyValuePair = standard.ContainerDescriptions.FirstOrDefault(kvp => kvp.Key == container.GetType());
            if (keyValuePair.Equals(default(KeyValuePair<Type, ContainerDescription>)))
                throw new InvalidOperationException();
            
            if (!keyValuePair.Value.IsMessagable)
                throw new ArgumentException("Message not sendable!");

            _standardVersion = standardVersion;
            _container = container;
            _containerId = keyValuePair.Value.Id;
        }

        public override Code Encode()
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(_standardVersion));

            var idEncoder = new IntEncoder(4);
            code.Append(idEncoder.Encode(_containerId));

            code.Append(_container.Encode());

            return code;
        }
    }
}
