namespace Polymorphism.Subtype;

public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;
    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _paymentProcessor.ProcessPayment(amount);
    }
}
