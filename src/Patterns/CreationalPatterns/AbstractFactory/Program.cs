using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;

NotificationFactory notificationFactory;
notificationFactory = new EmailNotificationFactory();
INotification emailNotification = notificationFactory.CreateNotification();
emailNotification.Send("Hello, via Email!");
notificationFactory = new SmsNotificationFactory();
INotification smsNotification = notificationFactory.CreateNotification();
smsNotification.Send("Hello, via Sms!");