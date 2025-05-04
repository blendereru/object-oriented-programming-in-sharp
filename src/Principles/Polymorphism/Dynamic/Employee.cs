namespace Polymorphism.Dynamic;

public class Employee
{
    public virtual double AmountPerHour { get; protected set; }
    public virtual double CalculateSalary(int hour)
    {
        var sum = AmountPerHour * hour;
        return sum;
    }
}