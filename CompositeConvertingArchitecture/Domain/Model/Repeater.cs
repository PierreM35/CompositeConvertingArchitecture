using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model.Coding;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Repeater(bool repeat) : Encodable
    {
        public bool Repeat { get; } = repeat;

        public override Code Encode() => new(Repeat);

        public static Repeater FromCode(Code code) => new(code.Extract(new BoolCoder()));
    }
}
