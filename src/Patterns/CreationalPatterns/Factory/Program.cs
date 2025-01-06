using Factory;
NotificationFactory notificationFactory = new NotificationFactory();
var smsNotification = notificationFactory.CreateNotification("Sms");
smsNotification.Send("Hello sms user");
var emailNotification = notificationFactory.CreateNotification("email");
emailNotification.Send("Hello email user");