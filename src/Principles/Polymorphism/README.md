# Polymorphism
Polymorphism is when you can treat an object as a generic version of something, but when you access it, the
code determines which exact type it is and calls the associated code. What is the advantage of it ? Well, it
allows the ability to write more generic and reusable code. Consider the following example that can be used
when creating a `Paint` app:
```csharp
public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw() => Console.WriteLine("Drawing Circle");
}

public class Square : IShape
{
    public void Draw() => Console.WriteLine("Drawing Square");
}

public class Canvas
{
    public void Render(IShape shape) => shape.Draw();
}
```
In this case, `Canvas` takes generic shape as a parameter, without needing to know the exact implementation 
of the `IShape` interface. Thus, when we need to add another implementation of `IShape`, there is no need
to know its type, at `runtime` the exact implementation delegates the execution of that code to the relevant
sub-class. This code is `polymorphic`(multi-formed), as it accepts any implementation of `IShape`.

## Types of polymorphism
There are different types of polymorphism:
### Static polymorphism
`Static` polymorphism - occurs at `compile` time. Refers to the ability  to resolve method 
calls at compile time rather than at runtime. Typical example is achieved through method `overloading`:
```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c) => a + b + c;
    public double Add(double a, double b)
    {
        return a + b;
    }
    
}

//using it
var calc = new Calculator();
Console.WriteLine($"Sum of 5, 6 is {calc.Add(5, 6)}");
var sum = calc.Add(7,8,9);
Console.WriteLine($"Sum of 7, 8 and 9 is {sum}");
```
Here, the calculator can call any signature of `Add` method, and can switch between them thus enabling it
to be polymorphic. Compiler is aware of the different method signatures and won't allow the calculator to
call non-existent method signatures of `Add`, thus detecting errors at `compile-time`(that is why it's static polymorhism).

### Dynamic polymorphism
Dynamic polymorphism resolves the method to call at `runtime`. This approach is generally called as just
polymorphism, because it describes the main idea behind the concept. It is generally achieved through
method `overriding`, when the method to call is resolved at runtime. Consider the example:
```csharp
public class Employee
{
    public virtual double AmountPerHour { get; protected set; }
    public virtual double CalculateSalary(int hour)
    {
        var sum = AmountPerHour * hour;
        return sum;
    }
}
public class FullTimeEmployee : Employee
{
    public override double AmountPerHour { get; protected set; } = 15;
    public override double CalculateSalary(int hour)
    {
        var sum = hour * (AmountPerHour + 5);
        Console.WriteLine($"The salary of the full time employee is {sum}$");
        return sum;
    }
}
public class PartTimeEmployee : Employee
{
    public override double AmountPerHour { get; protected set; } = 7.5;

    public override double CalculateSalary(int hour)
    {
        var sum = base.CalculateSalary(hour);
        Console.WriteLine($"The salary of part time employee is {sum + 500}$");
        return sum + 500;
    }
}

//using it
Employee employee = new PartTimeEmployee();
employee.CalculateSalary(30);
employee = new FullTimeEmployee();
employee.CalculateSalary(45);
```
The `employee` reference can point to any subclass of `Employee`, allowing for flexible code that can work
with different employee types interchangeably. If we didn't override the `CalculateSalary` the default
method in base class(Employee) is called, otherwise the child class` method gets called.

### Subtype polymorphism
This is a universal polymorphism type that gets implemented through inheritance(or subclassing). It
allows a function to operate on objects of different types, as long as they share a common base class
or interface. Consider the example:
```csharp
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}.");
    }
}
public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}.");
    }
}
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

// using it
IPaymentProcessor creditCardProcessor = new CreditCardPayment();
PaymentService paymentService = new PaymentService(creditCardProcessor);
paymentService.ProcessOrderPayment(100.00m);
IPaymentProcessor paypalProcessor = new PayPalPayment();
paymentService = new PaymentService(paypalProcessor);
paymentService.ProcessOrderPayment(200.00m);
```
`PaymentService` interacts with `IPaymentProcessor` without needing to know the specific payment processor
type. The part when we call different signatures of `ProcessOrderPayment` is the problem of dynamic
polymorphism, but the `PaymentService` accepting different types of implementations of `IPaymentProcessor`
but treating them as single is a part of the subtype polymorphism.

### Parametric polymorphism
Parametric polymorphism allows a single piece of code to be given a "generic" type, using variables
in place of actual types, and then instantiated with particular types as needed. `Parametric` polymorphism
allows code to be written generically, so that it can handle values uniformly without depending on their
type. This is achieved through the usage of `generics`. Consider the following example:
```csharp
public class Repository<T> where T : class, IEntity, new()
{
    private readonly string _connectionString;
    private readonly string _tableName;

    public Repository(string connectionString, string tableName)
    {
        _connectionString = connectionString;
        _tableName = tableName;
    }

    public void Add(T entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                if (entity is Customer customer)
                {
                    command.CommandText = $"INSERT INTO {_tableName} (Name, Email) VALUES (@Name, @Email)";
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                }
                else if (entity is Product product)
                {
                    command.CommandText = $"INSERT INTO {_tableName} (Name, Price) VALUES (@Name, @Price)";
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                }
                // Add additional entity type checks as needed

                command.ExecuteNonQuery();
            }
        }
    }
}

// using it
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
```
Here, `T` is a type parameter, and the class can operate on `any` type that satisfies the constraints
(class, IEntity, and has a parameterless constructor). This might look like the example of subtype 
polymorphism, but in comparison, the `Add` method doesn't rely on polymorphic behavior defined in
`IEntity`. It would make sense to use subtype polymorphism if our `Repository` was bound to specific 
method or property of `IEntity`. Like that:
```csharp
public class Customer : IEntity
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void AddToCommand(SqlCommand command)
    {
        command.CommandText = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";
        command.Parameters.AddWithValue("@Name", Name);
        command.Parameters.AddWithValue("@Email", Email);
    }
}

public class Product : IEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void AddToCommand(SqlCommand command)
    {
        command.CommandText = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
        command.Parameters.AddWithValue("@Name", Name);
        command.Parameters.AddWithValue("@Price", Price);
    }
}
public class Repository<T> where T : class, IEntity, new()
{
    private readonly string _connectionString;

    public Repository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Add(T entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                entity.AddToCommand(command);
                command.ExecuteNonQuery();
            }
        }
    }
}
```
Here, the `Repository` is bound to `AddToCommand` method of `IEntity`. But, from logical perspective,
it wouldn't make sense to add the `AddToCommand` method to `IEntity` as it introduces a `tight` coupling
between the domain model and the data access layer, violating the `Single Responsibility Principle (SRP)`.
By embedding database-specific logic like `AddToCommand` within the `IEntity` interface, we force every
entity to handle its own persistence logic. This means that any change in the database schema or
insertion logic would require modifications to the entity classes, which should ideally remain agnostic
of such concerns. That is why parametric polymorphism is perfect in this case, as it allows to take
any type as a parameter to the method, without being concerned of the actual type. 