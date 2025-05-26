using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

IMessageService messageService = new GrpcMessageService.GrpcMessageService();
messageService.MessageReceived += OnMessageReceived;

Console.WriteLine("Press anything to send message");
var input = Console.ReadLine();
while (!input.Equals("exit"))
{
    messageService.Send(new Message(4, 8, null));
    input = Console.ReadLine();
}

void OnMessageReceived(object? sender, Message e)
{
    Console.WriteLine($"Message received: Std: {e.StandardVersion}, ContainerId: {e.ContainerId}!");
}