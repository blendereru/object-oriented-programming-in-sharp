namespace Single_Responsibility.GoodExample;

public class Usage
{
    private readonly UserValidator _userValidator;
    public Usage(UserValidator userValidator)
    {
        _userValidator = userValidator;
    }
    public void Accept(User user)
    {
        if (_userValidator.IsValidEmail(user))
        {
            user.Greet();
            return;
        }
        Console.WriteLine("User is not valid");
    }
}