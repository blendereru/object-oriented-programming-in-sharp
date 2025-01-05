using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"The message was sent through email. The message: {message}");
    }
}