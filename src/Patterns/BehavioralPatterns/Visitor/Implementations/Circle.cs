using Visitor.BaseClasses;

namespace Visitor.Implementations;

public class Circle : IElement
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
    
}