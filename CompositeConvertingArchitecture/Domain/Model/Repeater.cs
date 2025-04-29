using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Repeater(bool repeat) : Encodable
    {
        public bool Repeat { get; } = repeat;

        public override Code Encode() => new(Repeat);
    }
}
