using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

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

        public override Container Decode(Code code, byte containerId)
        {
            if (!ContainerDescriptions.ContainsKey(containerId))
                throw new InvalidOperationException($"No container with Id {containerId} is registered in Standard version {Id}");

            var containerArguments = new List<Encodable>();
            var enumerator = ContainerDescriptions[containerId].ContainedTypes.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Type current = enumerator.Current;
                if (current.Equals(typeof(Escaper)))
                {
                    var escape = code.ExtractEscaper().Escape;
                    containerArguments.Add(new Escaper(escape));
                    if (escape)
                        enumerator.MoveNext();
                }

                if (current.Equals(typeof(Parameter1)))
                    containerArguments.Add(new Parameter1(code.Extract(Parameter1.GetCoder())));


            }

            return new Container(containerArguments);
        }

        private static Dictionary<byte, ContainerDescription> GetContainerDescriptions() =>
            new()
            {
                {
                    1,
                    new ContainerDescription(
                    typeof(Container1),
                    [
                        typeof(Parameter1),
                        typeof(Parameter2),
                        typeof(Parameter3),
                        typeof(Escaper),
                        typeof(Container2),
                        typeof(SomeEnum)
                    ],
                    true)
                },
                {
                    2,
                    new ContainerDescription(
                    typeof(Container2),
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
