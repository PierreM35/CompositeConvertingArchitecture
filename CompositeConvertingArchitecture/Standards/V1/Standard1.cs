using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Standards.V1
{
    public class Standard1 : Standard
    {
        public Standard1(List<(Type, IEnumerable<Type>, byte?)> containers, Dictionary<Type, byte> sizes) : base(GetContainers(), sizes)
        {
        }

        private static List<(Type, IEnumerable<Type>, byte?)> GetContainers()
        {
            return
            [
                (typeof(Container1), new List<Type> { typeof(Parameter1), typeof(Parameter2), typeof(Parameter3), typeof(Container2) }, 0)
            ];
        }
    }
}
