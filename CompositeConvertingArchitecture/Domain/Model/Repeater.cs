using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Repeater(bool isActiv) : Encodable
    {
        public bool IsActiv { get; } = isActiv;

        public override string Encode() => IsActiv ? "0" : "1";
    }
}
