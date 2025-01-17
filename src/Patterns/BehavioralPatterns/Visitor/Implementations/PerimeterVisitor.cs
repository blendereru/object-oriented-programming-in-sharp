using Visitor.BaseClasses;

namespace Visitor.Implementations;

public class PerimeterVisitor : IVisitor
{
    public void Visit(Rectangle rectangle)
    {
        var perimeter = (rectangle.Height + rectangle.Width) * 2;
        Console.WriteLine($"A rectangle with width {rectangle.Width} and height {rectangle.Height} has a perimeter equal to {perimeter}");
    }

    public void Visit(Circle circle)
    {
        var perimeter = 2 * Math.PI * circle.Radius;
        Console.WriteLine($"A circle with radious {circle.Radius} has a perimeter equal to {perimeter}");
    }
}