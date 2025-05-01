using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Standards.V1
{
    public class Container1 : Container
    {
        public Container1(Parameter1 param1, Parameter2 param2, Parameter3 param3, Container2 container2) 
            : base(GatherEncodables(param1, param2, container2, param3))
        {
        }

        public Container1(IEnumerable<Encodable> encodables) : base(encodables) { }

        private static List<Encodable> GatherEncodables(Parameter1 param1, Parameter2 param2, Container2 container2, Parameter3 param3)
            => [param1, param2, new Escaper(container2 == null), container2, param3];
    }
}
