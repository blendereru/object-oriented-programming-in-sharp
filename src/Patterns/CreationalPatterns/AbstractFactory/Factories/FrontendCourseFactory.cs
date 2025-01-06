namespace AbstractFactory.Factories;

public class FrontendCourseFactory : CourseFactory
{
    public override List<string> CourseNames { get; set; } = new List<string>()
    {
        "Javascript course", "Css course", "React course"
    };
}