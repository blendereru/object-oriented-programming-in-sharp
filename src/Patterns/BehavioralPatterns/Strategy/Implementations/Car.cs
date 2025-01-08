using Strategy.Interface;

namespace Strategy.Implementations;

public class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Moving by car will cost 40$");
    }
}