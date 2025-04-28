using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Escaper(bool activ) : Encodable
    {
        public bool Activ { get; } = activ;

        public override string Encode() => Activ ? "0" : "1";
    }
}
