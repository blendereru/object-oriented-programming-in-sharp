namespace Interface_Segregation.GoodExample;

public class OnlineRestaurant : IPaymentService, IOrderService
{
    public void ProcessOnlinePayment(string payment)
    {
        Console.WriteLine("Online payment processed.");
    }

    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken online.");
    }
    
}