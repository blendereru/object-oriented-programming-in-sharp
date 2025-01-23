namespace Liskov_Substitution.BadExample;

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("The bird is flying");
    }
}