using Visitor.BaseClasses;

namespace Visitor;

public class Elements
{
    private readonly List<IElement> _elements;

    public Elements()
    {
        _elements = new List<IElement>();
    }

    public void Accept(IVisitor visitor)
    {
        foreach (var element in _elements)
        {
            element.Accept(visitor);
        }
    }

    public void Add(IElement element)
    {
        _elements.Add(element);
        Console.WriteLine($"{element.GetType()} was added to the list");
    }

    public void Remove(IElement element)
    {
        if (_elements.Remove(element))
        {
            Console.WriteLine($"{element.GetType()} was removed from the list");
        }
    }
}