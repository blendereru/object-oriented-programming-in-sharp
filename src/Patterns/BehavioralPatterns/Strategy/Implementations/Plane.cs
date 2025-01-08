using Strategy.Interface;

namespace Strategy.Implementations;

public class Plane : IMovable
{
    public void Move()
    {
        Console.WriteLine("Moving by plane will cost 230$");
    }
}