namespace Interface_Segregation.BadExample;

public class DineInRestaurant : IRestaurantService
{
    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken.");
    }

    public void ProcessOnlinePayment(string payment)
    {
        throw new NotImplementedException("Dine-in does not support online payment.");
    }

    public void DeliverOrder(string address)
    {
        throw new NotImplementedException("Dine-in does not support delivery.");
    }
}
