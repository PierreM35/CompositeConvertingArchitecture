using ModelDigitalisationArchitecture.Domain.Abstractions;
using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Infrastructure.Coding.Extensions
{
    public static class ContainerExtensions
    {
        public static Code Encode(this Container container)
        {
            if (container is Container1 container1)
                return container1.Encode();

            if (container is Container2 container2)
                return container2.Encode();

            throw new NotImplementedException($"{container.GetType()} not implemented yet");
        }

        //Container structure:
        //Parameter1
        //Parameter2
        //Parameter3
        //Escaper
        //Container2
        //Enum1
        private static Code Encode(this Container1 container1)
        {
            var code = new Code();
            code.Append(container1.Parameter1.Encode());
            code.Append(container1.Parameter2.Encode());
            code.Append(container1.Parameter3.Encode());
            code.Append(new Code(container1.Container2 == null));

            if (container1.Container2 != null)
                code.Append(container1.Container2.Encode());

            code.Append(container1.Enum1.Encode());

            return code;
        }


        //Container structure:
        //Parameter2
        //IEnumerable<Parameter3>
        //Enum1
        private static Code Encode(this Container2 container2)
        {
            var code = new Code();
            code.Append(container2.Parameter2.Encode());

            if (container2.Parameter3s.Any())
            {
                code.Append(new Code(true));

                var list = container2.Parameter3s.ToList();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    code.Append(list[i].Encode());
                    code.Append(new Code(true));
                }

                code.Append(list.Last().Encode());
            }

            code.Append(new Code(false));

            code.Append(container2.Enum1.Encode());

            return code;
        }
    }
}
