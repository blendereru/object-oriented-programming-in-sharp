namespace Command;

public class FriesOrderCommand : ICommand
{
    public string Name { get { return "Fries"; } }
    private readonly Chef _chef;

    public FriesOrderCommand(Chef chef)
    {
        _chef = chef;
    }
    public void Execute()
    {
        _chef.PrepareFries();
    }

    public void Undo()
    {
        
    }
}