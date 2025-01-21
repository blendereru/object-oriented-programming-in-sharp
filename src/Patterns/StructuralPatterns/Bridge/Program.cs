using Bridge.Implementations;

var whatsApp = new Whatsapp();
var message = new TextMessage(whatsApp);
message.Send("Hello user! How are you doing?");


