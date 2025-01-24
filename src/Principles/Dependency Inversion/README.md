## Dependency Inversion Principle
The dependency inversion principle says:
* High level modules should not depend upon low-level modules. Both should depend upon abstractions.
* Abstractions should never depend upon details. Details should depend upon abstractions.

Imagine you are developing a service for order processing and you want to track the order's state by 
writing it in a logger provider. File logger is used in the current implementation and the overall system
can be written like:
```csharp
public class OrderProcessor
{
    private readonly FileLogger _logger;
    public OrderProcessor(FileLogger logger)
    {
        _logger = logger;
    }
    public void Process()
    {
        _logger.Log("The order was processed.");
    }
}
```
In this case,
* OrderProcessor - High level module, because it focuses on business logic.
* The FileLogger and ConsoleLogger classes are low-level modules, as they provide the actual implementation
details for logging.

But in that case, The OrderProcessor is tightly coupled to FileLogger. So when we want to change the
logger provider to console, we would need to modify the class itself, which would violate the Open/Closed
principle. So modifying a class like that would make more sense:
```csharp
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to console: {message}");
    }
}
```
and using it
```csharp
public class OrderProcessor
{
    private readonly ILogger _logger;

    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder()
    {
        _logger.Log("Order processed.");
    }
}
```
In this case we define ILogger interface as an abstraction. This abstraction serves as a bridge for
both High-level and Low-level modules. in that implementation we are following the 2 rules of the 
principle:
1. High level module(OrderProcessor) doesn't depend on low-level module(FileLogger).
2. Both low-level and high-level modules depend on abstraction.

## Advantages of the principle
* Loose Coupling: Easier to replace low-level components.
* Maintainability: Changes in low-level modules do not impact high-level logic.
