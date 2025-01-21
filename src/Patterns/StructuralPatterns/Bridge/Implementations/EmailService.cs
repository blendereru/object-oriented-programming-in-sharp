using Bridge.BaseClasses;

namespace Bridge.Implementations;

public class EmailService : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending email message: {message}");
    }
}