using DigitalMessageService.Model;
using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

namespace DigitalMessageService.Extensions
{
    public static class ContainerExtensions
    {
        public static Binary Encode(this Container container)
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
        private static Binary Encode(this Container1 container1)
        {
            var binary = new Binary();
            binary.Append(container1.Parameter1.Encode());
            binary.Append(container1.Parameter2.Encode());
            binary.Append(container1.Parameter3.Encode());
            binary.Append(new Binary(container1.Container2 == null));

            if (container1.Container2 != null)
                binary.Append(container1.Container2.Encode());

            binary.Append(container1.Enum1.Encode());

            return binary;
        }

        //Container structure:
        //Parameter2
        //IEnumerable<Parameter3>
        //Enum1
        private static Binary Encode(this Container2 container2)
        {
            var binary = new Binary();
            binary.Append(container2.Parameter2.Encode());

            if (container2.Parameter3s.Any())
            {
                binary.Append(new Binary(true));

                var list = container2.Parameter3s.ToList();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    binary.Append(list[i].Encode());
                    binary.Append(new Binary(true));
                }

                binary.Append(list.Last().Encode());
            }

            binary.Append(new Binary(false));

            binary.Append(container2.Enum1.Encode());

            return binary;
        }
    }
}
