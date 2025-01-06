namespace Builder.Product;

public class Burger
{
    public bool HasTomato { get; set; }
    public bool HasCucumber { get; set; }
    public int NumberOfPatties { get; set; }
    public List<string> Sauces { get; set; } = new List<string>();
}