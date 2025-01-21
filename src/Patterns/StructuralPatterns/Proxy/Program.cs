using Proxy;

Console.WriteLine("User with role 'User':");
var user = new User() { Name = "Tom" };
var userAccount = new BankAccountProxy(user);
Console.WriteLine("Proxy created, but bank account not initialized yet.");
userAccount.Deposit(500);
userAccount.WithDraw(200);
userAccount.GetBalance();

Console.WriteLine("\nUser with role 'Admin':");
var adminUser = new User() { Name = "John", Role = "Admin" };
var adminAccount = new BankAccountProxy(adminUser);
adminAccount.Deposit(1000);
adminAccount.WithDraw(300);
Console.WriteLine($"Admin can view balance: {adminAccount.GetBalance():C}");