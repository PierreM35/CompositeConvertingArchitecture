using CompositeConvertingArchitecture.Domain.Encoding;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Enumeration(Enum enumeration, byte index, byte bitSize) : Encodable
    {
        public object Value()
        {
            var enumValues = Enum.GetValues(enumeration.GetType());
            var enumerator = enumValues.GetEnumerator();

            var currentIndex = 0;
            while (enumerator.MoveNext())
            {
                if (currentIndex == index)
                    return enumerator.Current;

                currentIndex++;
            }

            throw new InvalidOperationException("Index invalid");
        }

        public override string Encode()
        {
            var coder = new ByteEncoder(bitSize);
            return coder.Encode(index);
        }
    }
}
