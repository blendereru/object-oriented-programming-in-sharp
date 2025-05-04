namespace Polymorphism.Dynamic;

public class FullTimeEmployee : Employee
{
    public override double AmountPerHour { get; protected set; } = 15;
    public override double CalculateSalary(int hour)
    {
        var sum = hour * (AmountPerHour + 5);
        Console.WriteLine($"The salary of the full time employee is {sum}$");
        return sum;
    }
}