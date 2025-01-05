using AbstractFactory.Interfaces;

namespace AbstractFactory.Implementations;

public class SmsNotificationFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}