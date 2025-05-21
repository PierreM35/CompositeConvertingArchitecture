using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions
{
    internal static class MessageExtensions
    {
        public static Binary Encode(this Message message)
        {
            var binary = new Binary();

            var versionEncoder = new StdVersionCoder();
            binary.Append(versionEncoder.Encode(message.StandardVersion));

            var idEncoder = new IntCoder(4);
            binary.Append(idEncoder.Encode(message.ContainerId));

            binary.Append(message.Container.Encode());

            return binary;
        }
    }
}
