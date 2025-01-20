namespace Composite;

public class Folder : Component
{
    private readonly List<Component> _files;

    public Folder(string fileName) : base(fileName)
    {
        _files = new List<Component>();
    }
    public override void Add(Component component)
    {
        _files.Add(component);
        Console.WriteLine($"File with the name {component.Name} was added to the folder");
    }

    public override void Remove(Component component)
    {
        if (_files.Remove(component))
        {
            Console.WriteLine($"File with the name {component.Name} was removed from the folder");
        }
    }

    public override void Display()
    {
        foreach (var file in _files)
        {
            Console.WriteLine(file.Name);
        }
    }
}