namespace Single_Responsibility.GoodExample;

public class UserValidator
{
    private readonly List<string> _validEmailEndings = new List<string>()
    {
        "@gmail.com", "@yahoo.com", "@mail.ru"
    };
    public bool IsValidEmail(User user)
    {
        var email = user.Email;
        return _validEmailEndings.Contains(email.Substring(email.IndexOf('@')));
    }
}