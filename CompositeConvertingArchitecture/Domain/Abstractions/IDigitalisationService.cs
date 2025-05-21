using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Digitalisation.Model;

namespace ModelDigitalisationArchitecture.Domain.Abstractions
{
    internal interface IDigitalisationService
    {
        Message Decode(Binary binary);
        Binary Encode(Message message);
    }
}