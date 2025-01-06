using Factory.Interfaces;

namespace Factory.Implementations;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"The message was sent through email. The message: {message}");
    }
}