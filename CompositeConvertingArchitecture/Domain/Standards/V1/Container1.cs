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
        public Enum1 Enum1 { get; }

        public Container1(Parameter1 param1, Parameter2 param2, Parameter3 param3, Enum1 enum1, Container2 container2 = null) 
            : base(GatherEncodables(param1, param2, container2, param3, enum1))
        {
            Parameter1 = param1;
            Parameter2 = param2;
            Parameter3 = param3;
            Container2 = container2;
            Enum1 = enum1;
        }

        public static Container1 CreateFrom(Code code)
        {
            var param1 = Parameter1.FromCode(code);
            var param2 = Parameter2.FromCode(code);
            var param3 = Parameter3.FromCode(code);
            var escaper = Escaper.FromCode(code);
            var container2 = escaper.Keep ? Container2.CreateFrom(code) : null;
            var enum1 = Enum1.FromCode(code);

            return new Container1(param1, param2, param3, enum1, container2);
        }

        private static List<Encodable> GatherEncodables(
            Parameter1 param1, 
            Parameter2 param2, 
            Container2 container2,
            Parameter3 param3, 
            Enum1 enum1)
            => [param1, param2, new Escaper(container2 == null), container2, param3, enum1];
    }
}
