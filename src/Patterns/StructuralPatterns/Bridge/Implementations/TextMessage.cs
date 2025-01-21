using Bridge.BaseClasses;

namespace Bridge.Implementations;

public class TextMessage : Message
{
    public TextMessage(IMessageSender sender) : base(sender) {}
    public override void Send(string content)
    {
        MessageSender.Send(content);
    }
}