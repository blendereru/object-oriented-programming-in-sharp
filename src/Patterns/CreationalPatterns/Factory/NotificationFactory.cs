using Factory.Implementations;
using Factory.Interfaces;

namespace Factory;

public class NotificationFactory
{
    public INotification CreateNotification(string type)
    {
        switch (type.ToLower())
        {
            case "sms":
                return new SmsNotification();
            default:
                return new EmailNotification();
        }
    }
}
