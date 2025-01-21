namespace Proxy;

public interface IBankAccount
{
    void Deposit(decimal amount);
    void WithDraw(decimal amount);
    decimal GetBalance();
}