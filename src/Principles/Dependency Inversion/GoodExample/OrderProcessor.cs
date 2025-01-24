namespace Dependency_Inversion.GoodExample;

public class OrderProcessor
{
    private readonly ILogger _logger;
    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }
    public void Process()
    {
        _logger.Log("The order was processed.");
    }
}