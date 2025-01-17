using Decorator.BaseClasses;

namespace Decorator.Implementations;

public abstract class LoggerDecorator : ILogger
{
    protected ILogger Logger;
    public LoggerDecorator(ILogger logger)
    {
        Logger = logger;
    }
    public virtual void Log(string message)
    {
        Logger.Log(message);
    }
}