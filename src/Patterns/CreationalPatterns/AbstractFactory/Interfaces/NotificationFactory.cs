using AbstractFactory.Implementations;

namespace AbstractFactory.Interfaces;

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
}
