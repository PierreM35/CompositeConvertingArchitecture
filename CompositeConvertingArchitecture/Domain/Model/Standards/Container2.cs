using CompositeConvertingArchitecture.Domain.Abstractions;

namespace CompositeConvertingArchitecture.Domain.Model.Standards
{
    //Container structure:
    //Parameter2
    //IEnumerable<Parameter3>
    //Enum1

    public class Container2(Parameter2 param2, IEnumerable<Parameter3> param3s, Enum1 enum1) :
        Container(GatherEncodables(param2, param3s, enum1))
    {
        public Parameter2 Parameter2 { get; } = param2;
        public IEnumerable<Parameter3> Parameter3s { get; } = param3s;
        public Enum1 Enum1 { get; } = enum1;

        public static Container2 FromCode(Code code)
        {
            var param2 = Parameter2.FromCode(code);
            var param3s = new List<Parameter3>();
            var repeater = Repeater.FromCode(code);
            if (repeater.Repeat)
            {
                do
                {
                    param3s.Add(Parameter3.FromCode(code));
                    repeater = Repeater.FromCode(code);
                } while (repeater.Repeat);
            }
            var enum1 = Enum1.FromCode(code);

            return new Container2(param2, param3s, enum1);
        }

        private static List<Encodable> GatherEncodables(Parameter2 param2, IEnumerable<Parameter3> param3s, Enum1 someEnum)
        {
            var encodables = new List<Encodable> { param2 };
            
            if (param3s.Any())
            {
                encodables.Add(new Repeater(true));

                var enumerator = param3s.GetEnumerator();
                while (enumerator.MoveNext())
                    encodables.AddRange([enumerator.Current, new Repeater(true)]);

                encodables.RemoveAt(encodables.Count - 1);
            }
                
            encodables.Add(new Repeater(false));

            encodables.Add(someEnum);

            return encodables;
        }
    }
}
