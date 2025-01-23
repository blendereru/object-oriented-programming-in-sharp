namespace Liskov_Substitution.GoodExample;

public class Ostrich : Bird
{
    public override void Display() => Console.WriteLine("I'm an ostrich. I cannot fly.");
}