using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Container1(Parameter1 param1, Parameter2 param2, Parameter3 param3, Enums.Enum1 enum1, Container2? container2 = null)
        : Container
    {
        public Parameter1 Parameter1 { get; } = param1;
        public Parameter2 Parameter2 { get; } = param2;
        public Parameter3 Parameter3 { get; } = param3;
        public Container2? Container2 { get; } = container2;
        public Enums.Enum1 Enum1 { get; } = enum1;
    }
}
