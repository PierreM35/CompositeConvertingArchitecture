using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public class Container(IEnumerable<Encodable> encodables) : Encodable()
    {
        public IEnumerable<Encodable> Encodables { get; } = encodables;         //IEnumerable -> immutable

        public override Code Encode()
        {
            var code = new Code();
            var enumerator = Encodables.GetEnumerator();
            while (enumerator.MoveNext())
                code.Append(enumerator.Current.Encode());

            return code;
        }
    }
}
