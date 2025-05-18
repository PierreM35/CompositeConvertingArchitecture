using ModelDigitalisationArchitecture.Domain.Model;
using ModelDigitalisationArchitecture.Infrastructure.Coding.Model;

namespace ModelDigitalisationArchitecture.Domain.Abstractions
{
    internal interface ICodingService
    {
        Message Decode(Code code);
        Code Encode(Message message);
    }
}