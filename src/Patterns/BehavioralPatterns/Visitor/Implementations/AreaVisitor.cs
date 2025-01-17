using Visitor.BaseClasses;

namespace Visitor.Implementations;

public class AreaVisitor : IVisitor
{
    public void Visit(Rectangle rectangle)
    {
        var area = rectangle.Height * rectangle.Width;
        Console.WriteLine($"A rectangle with width {rectangle.Width} and height {rectangle.Height} has an area equal to {area}");
    }

    public void Visit(Circle circle)
    {
        var area = Math.PI * circle.Radius * circle.Radius;
        Console.WriteLine($"A circle with radius {circle.Radius} has an are equal to {area}");
    }
}