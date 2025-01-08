using Observer.Models;

namespace Observer.BaseClasses;

public interface IObservable
{
    void RegisterObserver(Observer observer);
    void RemoveObserver(Observer observer);
    void NotifyObservers(Product product);
}