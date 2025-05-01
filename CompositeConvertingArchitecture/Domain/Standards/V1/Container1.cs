using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Container1 : Container
    {
        public Parameter1 Parameter1 { get; }
        public Parameter2 Parameter2 { get; }
        public Parameter3 Parameter3 { get; }
        public Container2 Container2 { get; }

        private Container1(Parameter1 param1, Parameter2 param2, Parameter3 param3, Container2 container2 = null) 
            : base(GatherEncodables(param1, param2, container2, param3))
        {
        }

        public static Container CreateFrom(Code code)
        {
            var dtg = encodables.GetEnumerator();
            var types = GetDescription().ContainedTypes.GetEnumerator();
            while (types.MoveNext())
            {
                dtg.MoveNext();

            }


            var containerArguments = new List<Encodable>();
            var types = ContainerDescriptions[containerId].ContainedTypes.GetEnumerator();
            while (types.MoveNext())
            {
                var type = types.Current;
                if (type.Equals(typeof(Escaper)))
                {
                    var escape = code.ExtractEscaper().Escape;
                    containerArguments.Add(new Escaper(escape));
                    if (escape)
                        types.MoveNext();
                }

                if (type.Equals(typeof(Parameter1)))
                    containerArguments.Add(new Parameter1(code.Extract(Parameter1.GetCoder())));


            }

            return new Container(containerArguments);

        }

        public static ContainerDescription GetDescription() => 
            new(
                [
                    typeof(Parameter1),
                    typeof(Parameter2),
                    typeof(Parameter3),
                    typeof(Escaper),
                    typeof(Container2),
                    typeof(SomeEnum)
                ],
                true);

        private static List<Encodable> GatherEncodables(Parameter1 param1, Parameter2 param2, Container2 container2, Parameter3 param3)
            => [param1, param2, new Escaper(container2 == null), container2, param3];
    }
}
