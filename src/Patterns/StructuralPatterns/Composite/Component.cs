namespace Composite;

public abstract class Component
{
    public string Name { get; set; }
    public Component(string fileName)
    {
        Name = fileName;
    }

    public virtual void Add(Component component) {}

    public virtual void Remove(Component component) {}
    public virtual void Display() {}
}