using Prototype.Prototype;

namespace Prototype;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override double GetPerimeter()
    {
        return (Width + Height) * 2;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override Shape Clone()
    {
        return (Rectangle)MemberwiseClone();
    }
}