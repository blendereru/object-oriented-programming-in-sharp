namespace Proxy;

public class BankAccountProxy : IBankAccount
{
    private readonly User _user;
    private readonly Lazy<BankAccount> _bankAccount;
    public BankAccountProxy(User user)
    {
        _user = user;
        _bankAccount = new Lazy<BankAccount>(() =>
        {
            Console.WriteLine("Initializing Bank Account...");
            return new BankAccount();
        });
    }

    public void Deposit(decimal amount)
    {
        if (string.Equals(_user.Role, "admin", StringComparison.OrdinalIgnoreCase))
        {
            _bankAccount.Value.Deposit(amount);
            return;
        }
        Console.WriteLine("Access Denied: Only Admins and Users can deposit money.");
    }

    public void WithDraw(decimal amount)
    {
        if (string.Equals(_user.Role, "admin", StringComparison.OrdinalIgnoreCase))
        {
            _bankAccount.Value.WithDraw(amount);
            return;
        }
        Console.WriteLine("Access Denied: Only Admins can withdraw money.");
    }

    public decimal GetBalance()
    {
        if (string.Equals(_user.Role, "admin", StringComparison.OrdinalIgnoreCase))
        {
            return _bankAccount.Value.GetBalance();
        }
        Console.WriteLine("Access Denied: Only Admins can withdraw money.");
        return 0;
    }
}