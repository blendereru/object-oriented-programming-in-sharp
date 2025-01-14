using ChainOfResponsibility;
using ChainOfResponsibility.Handler;

namespace ChainOfResponsibility.Implementations;
public class InfoLogger : Logger
{
    public InfoLogger() : base(LogLevel.Information) { }

    protected override void Write(string message)
    {
        Console.WriteLine($"INFO: {message}");
    }
}