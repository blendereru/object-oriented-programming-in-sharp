namespace Liskov_Substitution.BadExample;

public class Usage
{
    public void MakeBirdFly()
    {
        Bird bird = new Ostrich();
        bird.Fly();
    }
}