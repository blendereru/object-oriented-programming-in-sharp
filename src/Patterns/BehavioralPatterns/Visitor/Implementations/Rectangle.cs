using Visitor.BaseClasses;

namespace Visitor.Implementations;

public class Rectangle : IElement
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}