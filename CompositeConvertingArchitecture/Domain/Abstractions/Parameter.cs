namespace ModelDigitalisationArchitecture.Domain.Abstractions
{
    public abstract class Parameter<T>(T value)
    {
        public T Value { get; } = value;
    }
}
