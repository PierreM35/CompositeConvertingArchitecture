
namespace CompositeConvertingArchitecture.Infrastructure.Coding.Model
{
    public class Escaper(bool escape)
    {
        public bool Escape { get; } = escape;
        public bool Keep => !Escape;
    }
}
