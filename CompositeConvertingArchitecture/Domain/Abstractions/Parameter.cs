using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Parameter<T>(T value, Coder<T> coder) : Encodable()
    {
        public T Value { get; } = value;

        public override Code Encode() => coder.Encode(Value);
    }
}
