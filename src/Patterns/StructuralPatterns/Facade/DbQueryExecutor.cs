namespace Facade;

public class DbQueryExecutor
{
    public string Operation { get; set; }
    private readonly DbConnection _connection;
    public DbQueryExecutor(string operation, DbConnection connection)
    {
        Operation = operation;
        _connection = connection;
    }
    public void Execute()
    {
        Console.WriteLine($"Doing operation: {Operation}");
    }
}