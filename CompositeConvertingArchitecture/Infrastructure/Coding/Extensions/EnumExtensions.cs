using CompositeConvertingArchitecture.Domain.Enums;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Infrastructure.Coding.Extensions
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
