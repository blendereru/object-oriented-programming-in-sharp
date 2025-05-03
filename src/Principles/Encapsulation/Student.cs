namespace Encapsulation;
public class Student
{
    // Private fields
    private string _id;
    private string _name;
    private int _course;

    // Public properties with validation
    public string Id => _id;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            _name = value;
        }
    }

    public int Course
    {
        get => _course;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Course must be a positive integer.");
            _course = value;
        }
    }

    // Constructor
    public Student(string name, int course)
    {
        _id = Guid.NewGuid().ToString();
        Name = name;
        Course = course;
    }

    // Override Equals and GetHashCode for dictionary key usage
    public override bool Equals(object obj)
    {
        return obj is Student student && _id == student._id;
    }

    public override int GetHashCode()
    {
        return _id.GetHashCode();
    }
}
