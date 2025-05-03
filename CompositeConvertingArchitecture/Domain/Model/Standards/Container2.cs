using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    public class Container2(Parameter2 param2, IEnumerable<Parameter3> param3s, Enum1 someEnum) :
        Container(GatherEncodables(param2, param3s))
    {
        public static Container2 CreateFrom(Code code)
        {

        }

        private static List<Encodable> GatherEncodables(Parameter2 param2, IEnumerable<Parameter3> param3s)
        {
            var encodables = new List<Encodable> { param2, new Repeater(true) };

            var enumerator = param3s.GetEnumerator();
            while (enumerator.MoveNext())
                encodables.AddRange([enumerator.Current, new Repeater(true)]);

            encodables.RemoveAt(encodables.Count - 1);
            encodables.Add(new Repeater(false));

            return encodables;
        }
    }
}
