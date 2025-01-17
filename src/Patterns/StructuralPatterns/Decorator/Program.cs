using Decorator.BaseClasses;
using Decorator.Implementations;

ILogger logger = new ConsoleLogger();
logger = new TimestampLogger(logger);
logger.Log("This is a sample message");