namespace ModelDigitalisationArchitecture.Domain.Abstractions
{
    public abstract class Standard(byte id, Dictionary<byte, Type> containerTypes)
    {      
        public byte Id => id;
        public Dictionary<byte, Type> ContainerTypes => containerTypes;
    }
}
