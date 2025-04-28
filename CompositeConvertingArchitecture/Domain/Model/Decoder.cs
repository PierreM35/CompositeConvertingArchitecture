using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Decoder
    {
        private readonly string _originBits;
        private string _restBits;

        public Decoder(string bits)
        {
            if (bits.Any(c => !c.Equals("0") && !c.Equals("1")))
                throw new ArgumentException("Bits sequence must be made out of 0 and 1");

            _originBits = bits;
            _restBits = bits;
        }

        public Message Decode()
        {
            var stdVersion = ExtractStandardVersion();
            var containerId = ExtractContainerId();

            var standard = StandardSource.Standards[stdVersion];
            var stucture = standard.Containers.FirstOrDefault(a => a.Item3 is not null && a.Item3 == containerId).Item2;

            return new Message(stdVersion, GetContainer(standard, stucture));
        }

        private Container GetContainer(Standard standard, IEnumerable<Type> stucture)
        {
            var encodables = new List<Encodable>();
            foreach (var itemType in stucture)
            {
                if (itemType.IsAssignableFrom(typeof(Container)))
                    encodables.Add(GetContainer(standard, standard.Containers[itemType]));


            }

            return null;
        }

        private byte ExtractContainerId()
        {
            var decoder = new IdCoder();

            var id = decoder.Decode(_restBits[..IdCoder.IdBitsNb]);
            _restBits = _restBits[IdCoder.IdBitsNb..];

            return id;
        }

        private byte ExtractStandardVersion()
        {
            var decoder = new StdVersionCoder();

            var version = decoder.Decode(_restBits[..StdVersionCoder.StandardVersionBitsNb]);
            _restBits = _restBits[StdVersionCoder.StandardVersionBitsNb..];
            
            return version;
        }
    }
}
