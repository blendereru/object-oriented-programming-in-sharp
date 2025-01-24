namespace Interface_Segregation.GoodExample;

public class PaymentProcessor
{
    public void Process(IPaymentService service)
    {
        service.ProcessOnlinePayment("$100");
    }
}