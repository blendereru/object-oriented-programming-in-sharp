namespace AbstractFactory.Factories;

public abstract class Course
{
    private readonly string _courseName;
    protected Course(string courseName)
    {
        _courseName = courseName;
    }
    public void ShowCourseDefinition()
    {
        Console.WriteLine($"This course's name is {_courseName}");
    }
}