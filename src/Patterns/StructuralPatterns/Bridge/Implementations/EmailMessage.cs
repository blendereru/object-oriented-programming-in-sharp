using Bridge.BaseClasses;

namespace Bridge.Implementations;

public class EmailMessage : Message
{
    public EmailMessage(IMessageSender sender) : base(sender) {}
    public override void Send(string content)
    {
        MessageSender.Send(content);
    }
}