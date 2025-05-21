using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Coders;

namespace ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model
{
    public class Enumeration(Enum enumeration, byte index, byte bitSize)
    {
        public byte Index => index;
        public byte BitSize => bitSize;

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

        public  Binary Encode()
        {
            var coder = new ByteCoder(bitSize);
            return coder.Encode(index);
        }
    }
}
