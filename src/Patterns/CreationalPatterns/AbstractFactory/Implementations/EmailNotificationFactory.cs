using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class EmailNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}