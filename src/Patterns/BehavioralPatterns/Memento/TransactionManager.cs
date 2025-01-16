namespace Memento;

public class TransactionManager
{
    private readonly Stack<TransactionMemento> _stack = new Stack<TransactionMemento>();

    public void SaveTransactionOperation(Transaction transaction)
    {
        _stack.Push(transaction.SavePoint());
    }

    public void UndoTransaction(Transaction transaction)
    {
        if (_stack.Count > 0)
        {
            var memento = _stack.Pop();
            transaction.Rollback(memento);
        }
        else
        {
            Console.WriteLine("No states to restore.");
        }
    }
}