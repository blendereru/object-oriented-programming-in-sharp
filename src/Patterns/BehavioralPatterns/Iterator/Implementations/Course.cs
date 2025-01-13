using Iterator.Base;

namespace Iterator.Implementations;

public class Course : IStudentEnumerable
{
    private readonly List<Student> _students;

    public Student this[int index]
    {
        get => _students[index];
    }
    public Course()
    {
        _students = new List<Student>();
    }
    public IStudentIterator CreateEnumerator()
    {
        return new CourseNumerator(this);
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
        Console.WriteLine($"Student with name {student.Name} was added to the course");
    }

    public bool RemoveStudent(Student student)
    {
        return _students.Remove(student);
    }
    public int Count
    {
        get => _students.Count;
        set {}
    }
}