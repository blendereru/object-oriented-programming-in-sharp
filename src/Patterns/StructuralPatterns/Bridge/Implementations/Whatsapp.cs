using Bridge.BaseClasses;

namespace Bridge.Implementations;

public class Whatsapp : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending whatsapp message: {message}");
    }
}