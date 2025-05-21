namespace ModelDigitalisationArchitecture.Abstractions
{
    public abstract class Parameter<T>(T value)
    {
        public T Value { get; } = value;
    }
}
