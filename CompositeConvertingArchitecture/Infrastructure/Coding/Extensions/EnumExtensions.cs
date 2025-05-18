using ModelDigitalisationArchitecture.Domain.Enums;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Extensions
{
    public static class EnumExtensions
    {
        public static Code Encode(this Enum1 enum1)
        {
            var enumeration = new Enumeration(new Enum1(), (byte)enum1, 3);
            return enumeration.Encode(); 
        }
    }
}
