## Open/Closed Principle
The Open-Closed Principle states that software entities (such as modules, classes, functions, etc.) should be
open for extension but closed for modification. The idea is that the system has to be built in the way, so
that the additional changes has to be made through adding the new piece of code instead of changing the 
already existing ones.
## Understand through example
To understand the pattern, consider the following example:
```csharp
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class Circle
{
    public double Radius { get; set; }
}

public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        throw new ArgumentException("Unknown shape type");
    }
}
```
If we wanted to add a new shape called Triangle, we would need to modify the AreaCalculator by adding
the new `if` condition block and check if it is of type Triangle. Ok, adding a block for a single class 
check is not a problem, but what if we had over 1 million shapes ? We would need to add 1 million 
conditional blocks to check each type of shape. In that way, The AreaCalculator becomes difficult to
maintain and prone to bugs as new shapes are added.

Instead, the usage of the base class of `Shape` would provide a high maintainability of the code. 
```csharp
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}

public class AreaCalculator
{
    public double GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
```
So in this case, there is no need to check each type of shape all the time. If we wanted add a new shape
type, everything we would need to do is to implement the Shape class' `CalculateArea` method. In this
way we don't modify the existing class thus following the principle.

## Advantages of the Open/Closed principle
* Existing code remains unaltered when new features are added. This significantly reduces the risk of introducing bugs into already tested and proven code, ensuring stability and reliability.
* The core functionality of existing modules does not change, maintaining the application becomes simpler. Modifications are made by adding new code rather than changing the old one, which helps in maintaining a clean and organized codebase.