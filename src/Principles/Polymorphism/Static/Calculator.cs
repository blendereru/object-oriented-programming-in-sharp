namespace Polymorphism.Static;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b)
    {
        return a + b;
    }
}