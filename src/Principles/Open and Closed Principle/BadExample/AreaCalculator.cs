namespace Open_and_Closed_Principle.BadExample;

public class AreaCalculator
{
    public double GetArea(object shape)
    {
        if (shape is Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        throw new ArgumentException("Unknown shape type");
    }
}