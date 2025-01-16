namespace Memento;

public class TransactionMemento
{
    public string Operation { get; set; }

    public TransactionMemento(string operation)
    {
        Operation = operation;
    }
}