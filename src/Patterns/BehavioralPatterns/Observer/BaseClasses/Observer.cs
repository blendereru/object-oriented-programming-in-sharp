namespace Observer.BaseClasses;

public abstract class Observer
{
    public abstract string DesiredProductName { get; set; }

    public abstract void Update();
}