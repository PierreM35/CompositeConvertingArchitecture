using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Message(byte standardVersion, byte containerId, Container container) : Encodable
    {
        public override Code Encode()
        {
            var code = new Code();

            var versionEncoder = new StdVersionCoder();
            code.Append(versionEncoder.Encode(standardVersion));

            var idEncoder = new IntCoder(4);
            code.Append(idEncoder.Encode(containerId));

            code.Append(container.Encode());

            return code;
        }
    }
}
