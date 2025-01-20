namespace Facade;

public class DbQuery
{
    private readonly DbConnection _dbConnection;
    private readonly Transaction _transaction;

    public DbQuery(string connectionString)
    {
        _dbConnection = new DbConnection(connectionString);
        _transaction = new Transaction(_dbConnection);
    }

    public void ExecuteQuery(params string[] operations)
    {
        List<DbQueryExecutor> executors = new();
        try
        {
            foreach (var operation in operations)
            {
                executors.Add(new DbQueryExecutor(operation, _dbConnection));
            }
            _dbConnection.OpenConnection();
            _transaction.Commit(executors.ToArray());
            _dbConnection.CloseConnection();
        }
        catch
        {
            Console.WriteLine("An error was thrown when trying to commit the transactions");
            Console.WriteLine("Rolling back changes...");
            _transaction.Rollback();
        }
    }
}