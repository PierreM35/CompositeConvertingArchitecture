using DigitalMessageService.Coders;
using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Enums;
using ModelDigitalisationArchitecture.Model;
using ModelDigitalisationArchitecture.Utils;

namespace DigitalMessageService.Model
{
    public class Factory(Binary binary)
    {
        public Message ExtractMessage()
        {
            var stdVersion = ExtractStandardVersion();
            var standard = StandardSource.Standards.FirstOrDefault(s => s.Id == stdVersion)
                ?? throw new Exception($"Standard version {stdVersion} doesn't exist.");

            var containerId = ExtractContainerId();
            var containerType = standard.ContainerTypes[containerId];

            return new Message(
                stdVersion,
                containerId,
                ExtractContainer(containerType));
        }

        #region Private helpers

        private byte ExtractStandardVersion() => binary.Extract(new StdVersionCoder());

        private byte ExtractContainerId() => binary.Extract(new IdCoder());

        private Container ExtractContainer(Type containerType)
        {
            if (containerType == typeof(Container1))
                return ExtractContainer1();

            if (containerType == typeof(Container2))
                return ExtractContainer2();

            throw new NotImplementedException($"{containerType} not implemented yet.");
        }

        private Container1 ExtractContainer1()
        {
            var param1 = ExtractParameter1();
            var param2 = ExtractParameter2();
            var param3 = ExtractParameter3();
            var escaper = ExtractEscaper();
            var container2 = escaper.Keep ? ExtractContainer2() : null;
            var enum1 = ExtractEnum1();

            return new Container1(param1, param2, param3, enum1, container2);
        }

        private Container2 ExtractContainer2()
        {
            var param2 = ExtractParameter2();
            var param3s = new List<Parameter3>();
            var repeater = ExtractRepeater();
            if (repeater.Repeat)
            {
                do
                {
                    param3s.Add(ExtractParameter3());
                    repeater = ExtractRepeater();
                } while (repeater.Repeat);
            }
            var enum1 = ExtractEnum1();

            return new Container2(param2, param3s, enum1);
        }

        private Enum1 ExtractEnum1() => (Enum1)binary.Extract(new ByteCoder(3));
        private Parameter1 ExtractParameter1() => new(binary.Extract(CoderGetter.ForParameter1()));
        private Parameter2 ExtractParameter2() => new(binary.Extract(CoderGetter.ForParameter2()));
        private Parameter3 ExtractParameter3() => new(binary.Extract(CoderGetter.ForParameter3()));
        private Escaper ExtractEscaper() => new(binary.Extract(new BoolCoder()));
        private Repeater ExtractRepeater() => new(binary.Extract(new BoolCoder()));

        #endregion
    }
}
