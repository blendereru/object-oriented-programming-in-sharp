using Visitor.Implementations;

namespace Visitor.BaseClasses;

public interface IVisitor
{
    void Visit(Rectangle rectangle);
    void Visit(Circle circle);
}