namespace Polymorphism.Subtype;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}