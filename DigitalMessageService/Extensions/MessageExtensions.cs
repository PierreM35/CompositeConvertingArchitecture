using DigitalMessageService.Coders;
using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Model;

namespace DigitalMessageService.Extensions
{
    public static class MessageExtensions
    {
        public static Binary Encode(this Message message)
        {
            var binary = new Binary();

            var versionEncoder = new StdVersionCoder();
            binary.Append(versionEncoder.Encode(message.StandardVersion));

            var idEncoder = new IdCoder();
            binary.Append(idEncoder.Encode(message.ContainerId));

            binary.Append(message.Container.Encode());

            return binary;
        }
    }
}
