using Decorator.BaseClasses;

namespace Decorator.Implementations;

public class TimestampLogger : LoggerDecorator
{
    public TimestampLogger(ILogger logger) : base(logger) {}
    public override void Log(string message)
    {
        Logger.Log($"{DateTime.UtcNow} {message}");
    }
}