using Mediator.Implementations;

var chatroom = new ChatRoom();
var firstClient = new User(chatroom);
var secondClient = new User(chatroom);
var admin = new AdminUser(chatroom);
chatroom.AddClients(firstClient, secondClient, admin);
firstClient.Send("Hello World");
secondClient.Send("Hey what's up members ?");
admin.Send("This is a message from admin");