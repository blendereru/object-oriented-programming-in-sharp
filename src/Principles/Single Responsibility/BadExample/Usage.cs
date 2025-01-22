namespace Single_Responsibility.BadExample;

public class Usage
{
    public void Accept(User user)
    {
        if (user.IsValidEmail())
        {
            user.Greet();
        }
    } 
}