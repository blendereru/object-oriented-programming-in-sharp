namespace Interface_Segregation.BadExample;

public interface IRestaurantService
{
    void TakeOrder(string order);
    void ProcessOnlinePayment(string payment);
    void DeliverOrder(string address);
}
