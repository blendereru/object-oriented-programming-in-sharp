## Liskov substitution principle
The definition of the Liskov Substitution Principle states that:
> If S is a subtype of T, then objects of type T may be replaced with objects of type S without altering any
of the desirable properties of the program.

And the definition of the subtype states that:
> If S is a subtype of T, then any term of type S can be safely used in a context where a term
of type T is expected.

Generally you need to remember the rule:
If you need to add some restriction in an overridden method and that restriction doesn't exist in baseline
implementation, you probably violate Liskov Substitution Principle.

## Understand through example
When we want to define the base class for all types of birds we want to define a single method called
`Fly()`. But, in reality, not all birds can fly. If we were to fix this behaviour like that:
```csharp
public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new InvalidOperationException("Ostriches cannot fly!");
    }
}
```
We would obviously violate the LSP. The disadvantage of this approach is that the client doesn't even know
that ostriches can fly, so using the incorrect bird type would throw a runtime exception. So adding the
type check for each type of the bird can be a solution, but it blocks the extensibility(what if we 
wanted to add Penguin, which can't fly either).

So, to avoid the unexpected behaviour during the program execution the above behaviour can be rewritten
like:
```csharp
public interface IFlyable
{
    void Fly();
}

public abstract class Bird
{
    public abstract void Display();
}

public class Duck : Bird, IFlyable
{
    public override void Display() => Console.WriteLine("I'm a duck.");
    public void Fly() => Console.WriteLine("Duck is flying.");
}

public class Ostrich : Bird
{
    public override void Display() => Console.WriteLine("I'm an ostrich. I cannot fly.");
}
```
In that case, if we wanted to use Fly method on Ostrich class, compiler would indicate
Compile-time error: Ostrich doesn't support flying:
```csharp
Bird myDuck = new Duck();
MakeBirdFly((IFlyable)myDuck);  // OK

Bird myOstrich = new Ostrich();
// MakeBirdFly(myOstrich);  // Compile-time error
```

Thus, the Liskov substitution allow us to strengthen the correctness of the principle of constructing
a class hierarchy and applying a polymorphism, which leads to the rejection of false hierarchical 
inheritances and the creation of a more harmonious and consistent class system as a whole.