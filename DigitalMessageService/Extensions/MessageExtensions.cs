using DigitalMessageService.Abstractions;
using DigitalMessageService.Coders;
using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Model;

namespace DigitalMessageService.Extensions
{
    public static class MessageExtensions
    {
        public static Binary Encode<T>(this Message<T> message) where T : IEncodable
        {
            var binary = new Binary();

            var versionEncoder = new StdVersionCoder();
            binary.Append(versionEncoder.Encode(message.StandardVersion));

            var idEncoder = new IdCoder();
            binary.Append(idEncoder.Encode(message.ContainerId));

            binary.Append(message.Body.Encode());

            return binary;
        }
    }
}
