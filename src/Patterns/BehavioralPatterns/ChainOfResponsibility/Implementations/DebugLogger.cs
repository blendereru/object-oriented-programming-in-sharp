using ChainOfResponsibility.Handler;

namespace ChainOfResponsibility.Implementations;

public class DebugLogger : Logger
{
    public DebugLogger() : base(LogLevel.Debug)
    {
        
    }
    protected override void Write(string message)
    {
        Console.WriteLine($"DEBUG: {message}");
    }
}