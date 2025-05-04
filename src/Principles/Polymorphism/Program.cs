using Polymorphism.Dynamic;
using Polymorphism.Subtype;
using Polymorphism.Parametric;
using Polymorphism.Static;
//static
var calc = new Calculator();
Console.WriteLine($"Sum of 5, 6 is {calc.Add(5, 6)}");
var sum = calc.Add(7,8,9);
Console.WriteLine($"Sum of 7, 8 and 9 is {sum}");
//dynamic
Employee employee = new PartTimeEmployee();
employee.CalculateSalary(30);
employee = new FullTimeEmployee();
employee.CalculateSalary(45);
//subtype based
IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
PaymentService paymentService = new PaymentService(creditCardProcessor);
paymentService.ProcessOrderPayment(100.00m);

// Using PayPalPayment
IPaymentProcessor paypalProcessor = new PayPalProcessor();
paymentService = new PaymentService(paypalProcessor);
paymentService.ProcessOrderPayment(200.00m);
//parametric
var customerRepo = new Repository<Customer>("your_connection_string", "Customers");
var customer = new Customer()
{
    Name = "Mark",
    Email = "mark@gmail.com"
};
customerRepo.Add(customer);
var productRepo = new Repository<Product>("your_connection_string", "Products");
var product = new Product()
{
    Name = "Laptor XP",
    Price = 560
};
productRepo.Add(product);