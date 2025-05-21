using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Enums;

namespace DigitalMessageService.Extensions
{
    public static class EnumExtensions
    {
        public static Binary Encode(this Enum1 enum1)
        {
            var enumeration = new Enumeration(new Enum1(), (byte)enum1, 3);
            return enumeration.Encode(); 
        }
    }
}
