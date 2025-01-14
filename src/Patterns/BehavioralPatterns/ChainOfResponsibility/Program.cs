using ChainOfResponsibility;
using ChainOfResponsibility.Implementations;

var debugLogger = new DebugLogger();
var infoLogger = new InfoLogger();
var errorLogger = new ErrorLogger();

debugLogger.SetNextLogger(infoLogger);
infoLogger.SetNextLogger(errorLogger);
debugLogger.LogMessage(LogLevel.Debug, "This is a debug message");
debugLogger.LogMessage(LogLevel.Information, "This is an informational message.");
debugLogger.LogMessage(LogLevel.Error, "This is an error message.");