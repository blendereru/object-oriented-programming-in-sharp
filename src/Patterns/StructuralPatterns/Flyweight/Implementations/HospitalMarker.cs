using Flyweight.BaseClasses;

namespace Flyweight.Implementations;

public class HospitalMarker : ILocationMarker
{
    private readonly string _hospitalIcon;

    public HospitalMarker(string hospitalIcon)
    {
        _hospitalIcon = hospitalIcon;
    }
    public void Display(int latitude, int longitude)
    {
        Console.WriteLine($"{_hospitalIcon} at {latitude}, {longitude}");
    }
}