namespace Polymorphism.Dynamic;

public class PartTimeEmployee : Employee
{
    public override double AmountPerHour { get; protected set; } = 7.5;

    public override double CalculateSalary(int hour)
    {
        var sum = base.CalculateSalary(hour);
        Console.WriteLine($"The salary of part time employee is {sum + 500}$");
        return sum + 500;
    }
}