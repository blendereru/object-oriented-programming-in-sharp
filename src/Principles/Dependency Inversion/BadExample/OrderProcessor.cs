namespace Dependency_Inversion.BadExample;

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