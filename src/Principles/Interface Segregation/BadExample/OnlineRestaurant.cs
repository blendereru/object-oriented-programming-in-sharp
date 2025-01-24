namespace Interface_Segregation.BadExample;

public class OnlineRestaurant : IRestaurantService
{
    public void TakeOrder(string order)
    {
        throw new NotImplementedException("The order is not taken yet.");
    }

    public void DeliverOrder(string address)
    {
        throw new NotImplementedException("The order is not delivered yet.");
    }

    public void ProcessOnlinePayment(string payment)
    {
        Console.WriteLine("Processing payment...");
    }
}