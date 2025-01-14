namespace ChainOfResponsibility.Handler;

public abstract class Logger
{
    protected Logger? NextLogger;
    protected readonly LogLevel LogLevel;
    protected Logger(LogLevel logLevel)
    {
        LogLevel = logLevel;
    }

    public void SetNextLogger(Logger nextLogger)
    {
        NextLogger = nextLogger;
    }

    public void LogMessage(LogLevel logLevel, string message)
    {
        if (logLevel == LogLevel)
        {
            Write(message);
        }
        NextLogger?.LogMessage(logLevel, message);
    }

    protected abstract void Write(string message);
}