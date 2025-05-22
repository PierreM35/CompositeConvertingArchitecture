using DigitalMessageService.Model;

namespace DigitalMessageService.Abstractions
{
    public interface IEncodable
    {
        Binary Encode();
    }
}
