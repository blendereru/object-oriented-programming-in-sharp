namespace Interface_Segregation.BadExample;

public class PaymentProcessor
{
    public void Process(IRestaurantService restaurantService)
    {
        restaurantService.ProcessOnlinePayment("$100");
    }
}