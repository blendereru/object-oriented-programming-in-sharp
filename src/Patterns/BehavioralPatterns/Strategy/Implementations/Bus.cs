using Strategy.Interface;

namespace Strategy.Implementations;

public class Bus : IMovable
{
    public void Move()
    {
        Console.WriteLine("Moving by bus will cost 13$");
    }
}