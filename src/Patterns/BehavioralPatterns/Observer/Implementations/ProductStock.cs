using Observer.BaseClasses;
using Observer.Models;

namespace Observer.Implementations;

public class ProductStock : IObservable
{
    private List<BaseClasses.Observer> _observers;
    private List<Product> _products = new List<Product>();
    public ProductStock()
    {
        _observers = new List<BaseClasses.Observer>();
    }
    public void RegisterObserver(BaseClasses.Observer observer)
    {
        _observers.Add(observer);
    }

    public void NotifyObservers(Product product)
    {
        foreach (var observer in _observers.Where(o => o.DesiredProductName == product.ProductName))
        {
            observer.Update();
        }
    }

    public void RemoveObserver(BaseClasses.Observer observer)
    {
        _observers.Remove(observer);
    }

    public void Add(Product product)
    {
        _products.Add(product);
        if (product.IsAvailable)
        {
            NotifyObservers(product);
        }
    }
}