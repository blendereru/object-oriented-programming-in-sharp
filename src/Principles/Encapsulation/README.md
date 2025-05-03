## Encapsulation
Encapsulation is one of the core principles of OOP that involves  bundling data and the methods that operate
on that data within a single unit, typically a class. A class or struct can specify how accessible
each of its members is to code outside of the class or struct. Members not intended for consumers outside
of the class or assembly are hidden to limit the potential for coding errors or malicious exploits.(from 
microsoft doc). This is mainly achieved through access modifiers that allows to decide whether the data 
should be exposed to the outer world. Usually, fields are made `private`, so that the class itself could
manage it, and using `methods` to control the values being set:
```csharp
class User
{
    private string _name;
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("The name can't be empty");
        }
        _name = name;
    }
}
```
The example above restricts the program in setting the name parameter as empty value, which is true as a user
can't have an empty name. But we can't make the `_name` field public as in this case, we can't detect
the value being set. Or, if we want to get the user's name through the photo of the id card:
```csharp
class User
{
    private string _name;

    public void UploadDocument(Document document)
    {
        try
        {
            Dictionary<string, string> parsedValues = Document.Parse(document);
            if (parsedValues.ContainsKey("name"))
            {
                _name = parsedValues["name"];
            }
            else
            {
                Console.WriteLine("Photo is malicious, blocking the user");
                throw new CheckoutException("The document is malicious");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occured while parsing the id");
        }
    }
}
```
Here, the outer classes and the client itself don't need to know the internal `_name` field's existence
and the way it was extracted. It's all managed by the class, thus preventing others to modify the data.

## Example
In the example I use teacher-student relationship to show how encapsulation works. A teacher teaches
a specific subject and can put marks to the student at the end of the semester. To manage the students'
list we use `_studentMarks` field which gets changed when a student was added and the mark was put to 
the student.  The `_studentMarks` dictionary is private, preventing external classes from directly modifying student grades.
This provides a controlled interface for interaction.