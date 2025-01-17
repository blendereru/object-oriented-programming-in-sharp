namespace Visitor.BaseClasses;

public interface IElement
{
    void Accept(IVisitor visitor);
}