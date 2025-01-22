namespace Single_Responsibility.GoodExample;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public void Greet()
    {
        Console.WriteLine($"{Name}: Hello users");
    }
}