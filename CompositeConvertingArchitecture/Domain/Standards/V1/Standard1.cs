using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Standard1 : Standard
    {
        public Standard1() : base(1, GetContainerDescriptions())
        {
        }

        public Parameter1 GenerateParameter1(int value) => new(value);
        public Parameter2 GenerateParameter2(double value) => new(value);
        public Parameter3 GenerateParameter3(double value) => new(value);
        public Container1 GenerateContainer1(Parameter1 param1, Parameter2 param2, Parameter3 param3, Container2 container2) 
            => new(param1, param2, param3, container2);
        public Container2 GenerateContainer2(Parameter2 param2, IEnumerable<Parameter3> param3s, SomeEnum someEnum)
            => new(param2, param3s, someEnum);
        public SomeEnum GenerateSomeEnum(byte index, byte bitSize) => new(index, bitSize);

        private static IEnumerable<KeyValuePair<Type, ContainerDescription>> GetContainerDescriptions() => 
            new Dictionary<Type, ContainerDescription>
            {
                {
                    typeof(Container1),
                    new ContainerDescription(
                    1,
                    [
                        typeof(Parameter1),
                        typeof(Parameter2),
                        typeof(Parameter3),
                        typeof(Container2)
                    ],
                    true)
                },
                {
                    typeof(Container2),
                    new ContainerDescription(
                    1,
                    [
                        typeof(Parameter2),
                        typeof(List<Parameter3>),
                        typeof(SomeEnum)
                    ],
                    true)
                }
            };
    }
}
