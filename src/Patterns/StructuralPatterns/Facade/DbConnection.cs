namespace Facade;

public class DbConnection
{
    private readonly string _connectionString;
    private readonly List<string> _connectionsPool = new List<string>();
    public DbConnection(string connectionString)
    {
        if (!_connectionsPool.Contains(connectionString))
        {
            _connectionsPool.Add(connectionString);
            _connectionString = connectionString;
            Console.WriteLine("Connection string was not found in db. Adding to pool...");
        }
        else
        {
            _connectionString = _connectionsPool.First(c => c == connectionString);
            Console.WriteLine("Connection string was already added to pool.");
        }
    }
    public void OpenConnection()
    {
        Console.WriteLine("The connection is opened");
    }

    public void CloseConnection()
    {
        Console.WriteLine("Closing the connection.");
    }
}