using Flyweight.BaseClasses;

namespace Flyweight.Implementations;

public class RestaurantMarker : ILocationMarker
{
    private readonly string _restaurantIcon;

    public RestaurantMarker(string restaurantIcon)
    {
        _restaurantIcon = restaurantIcon;
    }
    public void Display(int latitude, int longitude)
    {
        Console.WriteLine($"{_restaurantIcon} at {latitude}, {longitude}");
    }
}