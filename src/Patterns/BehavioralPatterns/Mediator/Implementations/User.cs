using Mediator.BaseClasses;

namespace Mediator.Implementations;

public class User : Client
{
    public User(IMediator mediator) : base(mediator) {}
    public override void Notify(string message)
    {
        Console.WriteLine($"User {Id} has received message: {message}");
    }
}