using CompositeConvertingArchitecture.Domain.Model;
using CompositeConvertingArchitecture.Infrastructure.Coding.Model;

namespace CompositeConvertingArchitecture.Domain.Abstractions
{
    internal interface ICodingService
    {
        Message Decode(Code code);
        Code Encode(Message message);
    }
}