namespace Observer.Implementations;
public class User : BaseClasses.Observer
{
    public override string DesiredProductName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public override void Update()
    {
        Console.WriteLine($"User {Name} was notified about availability of his product called {DesiredProductName}");
    }
}