using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Domain.Utils;
using CompositeConvertingArchitecture.Infrastructure.Coding.Coders;
using CompositeConvertingArchitecture.Infrastructure.Coding.Extensions;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding
{
    public class CodingService() : ICodingService
    {
        public Code Encode(Message message)
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(message.StandardVersion));

            var idEncoder = new IntCoder(4);
            code.Append(idEncoder.Encode(message.ContainerId));

            code.Append(message.Container.Encode());

            return code;
        }

        public Message Decode(Code code)
        {
            var stdVersion = code.ExtractStandardVersion();
            var standard = StandardSource.Standards.FirstOrDefault(s => s.Id == stdVersion)
                ?? throw new Exception($"Standard version {stdVersion} doesn't exist.");

            var containerId = code.ExtractContainerId();
            var containerType = standard.ContainerTypes[containerId];

            return new Message(
                stdVersion,
                containerId,
                code.Extract(containerType));
        }
    }
}
