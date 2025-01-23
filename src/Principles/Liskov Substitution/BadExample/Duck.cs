namespace Liskov_Substitution.BadExample;

public class Duck : Bird
{
    public override void Fly()
    {
        Console.WriteLine("The fuck if flying");
    }
}