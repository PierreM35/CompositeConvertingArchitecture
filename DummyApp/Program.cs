using ModelDigitalisationArchitecture.Abstractions;
using ModelDigitalisationArchitecture.Model;

IMessageService messageService = new GrpcMessageService.GrpcMessageService();
messageService.MessageReceived += OnMessagereceived;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Press anything to send message");

Console.ReadLine();
messageService.Send(new Message(4, 8, null));



void OnMessagereceived(object? sender, Message e)
{
    Console.WriteLine($"Message received: Std: {e.StandardVersion}, ContainerId: {e.ContainerId}!");
}