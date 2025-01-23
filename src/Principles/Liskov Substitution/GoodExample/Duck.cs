namespace Liskov_Substitution.GoodExample;


public class Duck : Bird, IFlyable
{
    public override void Display() => Console.WriteLine("I'm a duck.");
    public void Fly() => Console.WriteLine("Duck is flying.");
}