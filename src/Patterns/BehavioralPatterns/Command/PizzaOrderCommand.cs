namespace Command;

public class PizzaOrderCommand : ICommand
{
    public string Name
    {
        get { return "Pizza"; }
    }

    private readonly Chef _chef;

    public PizzaOrderCommand(Chef chef)
    {
        _chef = chef;
    }
    public void Execute()
    {
        _chef.PreparePizza();
    }

    public void Undo()
    {
        _chef.CancelPizzaPreparation();
    }
}