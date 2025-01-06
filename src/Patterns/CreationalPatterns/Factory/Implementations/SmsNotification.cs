using Factory.Interfaces;

namespace Factory.Implementations;

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}