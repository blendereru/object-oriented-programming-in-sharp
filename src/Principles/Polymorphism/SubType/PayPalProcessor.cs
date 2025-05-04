namespace Polymorphism.Subtype;

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}.");
        // PayPal processing logic here
    }
}