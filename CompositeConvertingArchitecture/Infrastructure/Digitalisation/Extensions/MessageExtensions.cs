using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Extensions
{
    internal static class MessageExtensions
    {
        public static Code Encode(this Message message)
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(message.StandardVersion));

            var idEncoder = new IntCoder(4);
            code.Append(idEncoder.Encode(message.ContainerId));

            code.Append(message.Container.Encode());

            return code;
        }
    }
}
