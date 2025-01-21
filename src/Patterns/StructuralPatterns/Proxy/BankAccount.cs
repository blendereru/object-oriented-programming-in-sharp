namespace Proxy;

public class BankAccount : IBankAccount
{
    private decimal _balance;
    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Deposited {amount:C}. Current balance: {_balance:C}");
    }

    public void WithDraw(decimal amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. Remaining balance: {_balance:C}");
            return;
        }
        Console.WriteLine("Insufficient funds.");
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}