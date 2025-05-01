using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Standard1 : Standard
    {
        public Standard1() : base(1, GetFactoryMethods())
        {
        }

        private static Dictionary<byte, Func<Code, Container>> GetFactoryMethods()
            => new()
            {
                { 1, Container1.CreateFrom }
            };

        //private static Dictionary<byte, ContainerDescription> GetContainerDescriptions() =>
        //    new()
        //    {
        //        { 1, Container1.GetDescription() },
        //        {
        //            2,
        //            new ContainerDescription(
        //            [
        //                typeof(Parameter2),
        //                typeof(List<Parameter3>),
        //                typeof(SomeEnum)
        //            ],
        //            true)
        //        }
        //    };
    }
}
