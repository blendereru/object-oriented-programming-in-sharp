using Mediator.BaseClasses;

namespace Mediator.Implementations;

public class ChatRoom : IMediator
{
    private List<Client> _clients;

    public ChatRoom()
    {
        _clients = new List<Client>();
    }

    public void AddClient(Client client)
    {
        _clients.Add(client);
        Console.WriteLine($"Client {client.Id} was added to chat room");
    }

    public void AddClients(params Client[] clients)
    {
        _clients.AddRange(clients);
        foreach (var client in clients)
        {
            Console.WriteLine($"Client {client.Id} was added to chat room");
        }
    }
    
    public void Send(string message, Client client)
    {
        foreach (var notifiable in _clients.Where(c => c.Id != client.Id))
        {
            notifiable.Notify(message);
        }
    }
}