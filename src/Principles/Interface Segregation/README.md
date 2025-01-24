## Interface Segregation Principle
> Clients should not be forced to implement any methods they don’t use. Rather than one fat interface,
numerous little interfaces are preferred based on groups of methods, with each interface serving one
submodule.

The principle generally means that clients shouldn't depend on methods that they don't use.

## Understand through example
We could have an app that works with different restaurant types(e.g. DineInRestaurant, OnlineRestaurant).
All restaurants can take the order, deliver it, and process the payment for the service. So the base
class(interface) could be defined like:
```csharp
public interface IRestaurantService
{
    void TakeOrder(string order);
    void ProcessOnlinePayment(string payment);
    void DeliverOrder(string address);
}
```
But the main disadvantage of this is that every restaurant serve the clients differently. For example,
some restaurants might require processing the payment first, and delivering the food after, or some 
restaurants might not support online payment at all. So when using this base class like:
```csharp
public class PaymentProcessor
{
    public void Process(IRestaurantService restaurantService)
    {
        restaurantService.ProcessOnlinePayment("$100");
    }
}
```
the class that implements `IRestaurantService` and doesn't support online payment, would throw a runtime
exception:
```csharp
public class DineInRestaurant : IRestaurantService
{
    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken.");
    }

    public void ProcessOnlinePayment(string payment)
    {
        throw new NotImplementedException("Dine-in does not support online payment.");
    }

    public void DeliverOrder(string address)
    {
        throw new NotImplementedException("Dine-in does not support delivery.");
    }
}
```
In that case, we violate the [LSP](https://github.com/blendereru/design-patterns-principles/blob/3999b96610cf679785d8f4c5781d4358bee12fcf/src/Principles/Liskov%20Substitution/Liskov%20Substitution.csproj)(Liskov Substitution Principle).
To solve this issue, let's think about PaymentProcessor. The payment processor doesn't care about the
restaurant type that is processing the payment. Everything it needs is the method `ProcessOnlinePayment`.
So it would make more sense if we pass as a parameter to the `PaymentProcessor` a restaurant that supports
online payment without expecting a runtime exception, so the classes that doesn't support online 
payment wouldn't even define a method `ProcessOnlinePayment`. So the possible solution is:
```csharp
public interface IOrderService
{
    void TakeOrder(string order);
}

public interface IPaymentService
{
    void ProcessOnlinePayment(string payment);
}

public interface IDeliveryService
{
    void DeliverOrder(string address);
}
```
and each restaurant would implement the necessary interface:
```csharp
public class DineInRestaurant : IOrderService
{
    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken for dine-in.");
    }
}

public class OnlineRestaurant : IOrderService, IPaymentService, IDeliveryService
{
    public void TakeOrder(string order)
    {
        Console.WriteLine("Order taken online.");
    }

    public void ProcessOnlinePayment(string payment)
    {
        Console.WriteLine("Online payment processed.");
    }

    public void DeliverOrder(string address)
    {
        Console.WriteLine("Order delivered to address.");
    }
}
```
so now, we can only pass the interface, implementers of which does support online payment:
```csharp
public class PaymentProcessor
{
    public void Process(IPaymentService service)
    {
        service.ProcessOnlinePayment("$100");
    }
}
```
## Signs that you violate the Interface Segregation
* Fat interfaces - interfaces that has a lot of methods that are not related to each other.
* Implementers that violate `LSP` - the ones that don't implement the interface method or implements it
through throwing the exception.

