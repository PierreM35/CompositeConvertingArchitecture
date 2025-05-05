using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Container(IEnumerable<Encodable> encodables) : Encodable()
    {
        public override Code Encode()
        {
            var code = new Code();
            var enumerator = encodables.GetEnumerator();
            while (enumerator.MoveNext())
            {
                code.Append(enumerator.Current.Encode());
                if (enumerator.Current is Escaper escaper && escaper.Escape)
                    enumerator.MoveNext();
            }

            return code;
        }
    }
}
