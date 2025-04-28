namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Parameter<T>(T value, Coder<T> encoder) : Encodable()
    {
        private readonly Coder<T> _encoder = encoder;

        public T Value { get; } = value;

        public override string Encode() => _encoder.Encode(Value);
    }
}
