using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Escaper(bool escape) : Encodable
    {
        public bool Escape { get; } = escape;
        public bool Keep => !Escape;

        public override Code Encode() => new(Keep);

        public static Escaper FromCode(Code code) => new(code.Extract(new BoolCoder()));
    }
}
