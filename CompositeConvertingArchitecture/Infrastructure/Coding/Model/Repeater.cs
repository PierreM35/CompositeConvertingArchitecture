
namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Model
{
    public class Repeater(bool repeat)
    {
        public bool Repeat { get; } = repeat;
        public bool Stop => !Repeat;
    }
}
