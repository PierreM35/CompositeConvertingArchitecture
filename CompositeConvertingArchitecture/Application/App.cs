using CompositeConvertingArchitecture.Domain.Abstractions;
using CompositeConvertingArchitecture.Domain.Model;

namespace CompositeConvertingArchitecture.Application
{
    public class App
    {
        private IMessageService _messageService;

        public App(IMessageService messageService)
        {
            _messageService = messageService;
            _messageService.MessageReceived += OnMessageReceived;
        }

        private void OnMessageReceived(object? sender, Message message)
        {
            throw new NotImplementedException();
        }
    }
}
