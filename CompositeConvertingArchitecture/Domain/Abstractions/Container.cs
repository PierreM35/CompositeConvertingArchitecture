using CompositeConvertingArchitecture.Domain.Model;
using System.Text;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    public abstract class Container(IEnumerable<Encodable> encodables) : Encodable()
    {
        public IEnumerable<Encodable> Encodables { get; } = encodables;         //IEnumerable -> immutable

        public override string Encode()
        {
            var code = new StringBuilder();
            var escape = false;
            var enumerator = Encodables.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var encodable = enumerator.Current;
                if (escape)
                    escape = false;
                else
                    code.Append(encodable.Encode());

                if (encodable is Escaper escaper && escaper.Activ)
                    escape = true;
            }

            return code.ToString();
        }
    }
}
