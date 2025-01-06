using AbstractFactory.Implementations;

namespace AbstractFactory.Factories;

public class BackendCourseFactory : CourseFactory
{
    public override List<string> CourseNames { get; set; } = new List<string>()
    {
        "C# course", "Java course", "Python course"
    };
    public Course CreateJavaCourse()
    {
        return new JavaCourse(CourseNames[1]);
    }
}