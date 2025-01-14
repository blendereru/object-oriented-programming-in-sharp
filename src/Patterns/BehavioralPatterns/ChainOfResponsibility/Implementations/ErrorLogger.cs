using ChainOfResponsibility.Handler;

namespace ChainOfResponsibility.Implementations;

public class ErrorLogger : Logger
{
    public ErrorLogger() : base(LogLevel.Error)
    {
        
    }
    protected override void Write(string message)
    {
        Console.WriteLine($"ERROR: {message}");
    }
}