namespace Interface_Segregation.GoodExample;

public class DineInRestaurant : IOrderService
{
    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken for dine-in.");
    }
}