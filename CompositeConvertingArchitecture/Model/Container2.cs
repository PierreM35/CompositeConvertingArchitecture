using ModelDigitalisationArchitecture.Abstractions;

namespace ModelDigitalisationArchitecture.Model
{
    public class Container2(Parameter2 param2, IEnumerable<Parameter3> param3s, Enums.Enum1 enum1) : Container
    {
        public Parameter2 Parameter2 { get; } = param2;
        public IEnumerable<Parameter3> Parameter3s { get; } = param3s;
        public Enums.Enum1 Enum1 { get; } = enum1;
    }
}
