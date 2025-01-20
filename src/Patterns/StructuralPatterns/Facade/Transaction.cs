namespace Facade;

public class Transaction
{
    private readonly List<DbQueryExecutor> _dbQueryExecutors = new List<DbQueryExecutor>();
    private readonly DbConnection _connection;
    public Transaction(DbConnection connection)
    {
        _connection = connection;
    }
    public void Commit(params DbQueryExecutor[] dbQueryExecutors)
    {
        _dbQueryExecutors.AddRange(dbQueryExecutors);
        foreach (var query in _dbQueryExecutors)
        {
            query.Execute();
            Thread.Sleep(1000);
            Console.WriteLine($"Query was successfully executed.");
        }
    }
    public void Rollback()
    {
        Console.WriteLine("Rolling back all operations...");
    }
}