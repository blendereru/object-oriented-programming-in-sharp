namespace Single_Responsibility.BadExample;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public void Greet()
    {
        Console.WriteLine($"{Name}: Hi users!");
    }

    public bool IsValidEmail()
    {
        return Email.EndsWith("@gmail.com");
    }
}