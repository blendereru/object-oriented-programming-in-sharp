namespace Memento;

public class Transaction
{
    private string _operation;

    public void DoOperation(string operation)
    {
        _operation = operation;
        Console.WriteLine($"Transaction operation: {operation}");
    }

    public string CurrentOperation()
    {
        return _operation;
    }

    public TransactionMemento SavePoint()
    {
        Console.WriteLine($"Adding savepoint to: {_operation}");
        return new TransactionMemento(_operation);
    }

    public void Rollback(TransactionMemento memento)
    {
        _operation = memento.Operation;
        Console.WriteLine($"Transaction rollback to: {_operation}");
    }
}