namespace Iterator.Implementations;

public class University
{
    public void DisplayStudents(Course course)
    {
        Console.WriteLine("The course has the students:");
        var iterator = course.CreateEnumerator();
        while (iterator.HasNext())
        {
            var student = iterator.Next();
            Console.WriteLine(student.Name);
        }
    }
}