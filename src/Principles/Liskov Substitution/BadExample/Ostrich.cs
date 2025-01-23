namespace Liskov_Substitution.BadExample;

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new InvalidOperationException("Ostriches cannot fly!");
    }
}