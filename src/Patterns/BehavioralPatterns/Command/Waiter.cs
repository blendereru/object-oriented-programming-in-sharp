namespace Command;

public class Waiter
{
    private readonly List<ICommand> _commands = new List<ICommand>();

    public void TakeOrder(ICommand command)
    {
        _commands.Add(command);
        Console.WriteLine($"Waiter has received command {command.Name}");
    }

    public void PlaceOrders()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    public void CancelOrder(ICommand command)
    {
        var cancelCommand = _commands.FirstOrDefault(c => c.Name == command.Name);
        if (cancelCommand == null)
        {
            return;
        }
        _commands.Remove(cancelCommand);
        cancelCommand.Undo();
    }
}