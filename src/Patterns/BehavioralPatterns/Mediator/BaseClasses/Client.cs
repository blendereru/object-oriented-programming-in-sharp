namespace Mediator.BaseClasses;

public abstract class Client
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public IMediator Mediator { get; set; }

    protected Client(IMediator mediator)
    {
        Mediator = mediator;
    }

    public abstract void Notify(string message);

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }
}