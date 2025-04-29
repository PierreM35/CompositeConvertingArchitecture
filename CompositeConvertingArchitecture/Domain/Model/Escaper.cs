using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model
{
    public class Escaper(bool escape) : Encodable
    {
        public bool Escape { get; } = escape;
        public bool DontEscape => !Escape;

        public override Code Encode() => new(DontEscape);
    }
}
