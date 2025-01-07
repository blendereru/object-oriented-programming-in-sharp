using Prototype.Prototype;

namespace Prototype;

public class Circle : Shape
{
    public int Radius { get; set; }
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override Shape Clone()
    {
        return (Circle)MemberwiseClone();
    }
}