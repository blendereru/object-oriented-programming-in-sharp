namespace Mediator.BaseClasses;

public interface IMediator
{
    void Send(string message, Client client);
}