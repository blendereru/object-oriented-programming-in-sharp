## Single Responsibility Principle
The Single Responsibility Pattern states that a class should have only one reason to change, meaning it
should have only one job or responsibility. The entire functionality of the component should have a high
cohesion. This doesn't mean that a class should contains a single method. You can have multiple methods
if they are related to a single responsibility or functionality.

## Understand through example
Take a look at the following example:
```csharp
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
```
Here, the User class has 2 responsibility: greeting the audience, and validating the email. But the
main disadvantage of this approach is that if we want to check the email for another domain validity(e.g.
yahoo or outlook), we would need to modify the User class by adding the list of valid email endings thus
adding unrelated logic to the class. Separating the logic of email validation to another class would make
this much more sensible. Now, EmailValidator contains a single method called `IsValidEmail` and under the hood
checks if the user's email ending is present in the `_validEmailEndings` field.

This approach is advantageous as the business logic and the UI logic are now separated. Imagine if we 
want to add the other validation such as a validation of the phone number. In this case no need to alter
the User class as Business logic is now is the responsibility of the UserValidator class, and all
validation logic will be defined there thus keeping the code and the logic clean. 

## Advantages of the Single Responsibility pattern
* Classes with a single responsibility are typically smaller and more focused, which makes them easier
to understand. Each class has a clear purpose so developers can quickly understand what it does.
* When classes are designed with just one responsibility, changes in the system’s requirements affect
fewer components. This makes it easier to update and maintain the code since changes to one part of the 
system are less likely to affect other parts.
