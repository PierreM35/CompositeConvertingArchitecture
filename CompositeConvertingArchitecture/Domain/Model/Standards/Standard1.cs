using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Standard1 : Standard
    {
        public Standard1() : base(1, GetFactoryMethods())
        {
        }

        private static Dictionary<byte, Func<Code, Container>> GetFactoryMethods()
            => new()
            {
                { 1, Container1.CreateFrom },
                { 2, Container2.CreateFrom }
            };
    }
}
