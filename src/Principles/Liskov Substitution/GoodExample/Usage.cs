namespace Liskov_Substitution.GoodExample;

public class Usage
{
    public void MakeBirdFly(IFlyable flyable)
    {
        flyable.Fly();
    }
}