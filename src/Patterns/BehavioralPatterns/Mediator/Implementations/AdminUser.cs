using Mediator.BaseClasses;

namespace Mediator.Implementations;

public class AdminUser : Client
{
    public AdminUser(IMediator mediator) : base(mediator) {}
    public override void Notify(string message)
    {
        Console.WriteLine($"Admin {Id} has received message: {message}");
    }
}