namespace Encapsulation;

public class Teacher
{
    private readonly Dictionary<Student, string> _studentMarks;
    public string Subject { get; set; }
    public string Name { get; set; }

    public Teacher(string name, string subject)
    {
        Subject = subject;
        Name = name;
        _studentMarks = new Dictionary<Student, string>();
    }
    public void PutMark(Student student, string value)
    {
        if (!_studentMarks.ContainsKey(student))
        {
            Console.WriteLine($"{student.Id} is not your student!");
            return;
        }
        _studentMarks[student] = value;
    }
    public void AddStudent(Student student)
    {
        _studentMarks.Add(student, string.Empty);
        Console.WriteLine($"[{student.Id}] The student {student.Name} of {student.Course}th grade was added");
    }

    public void ShowMarks()
    {
        foreach (var studentMark in _studentMarks)
        {
            var student = studentMark.Key;
            var mark = studentMark.Value;
            if (string.IsNullOrEmpty(mark))
            {
                mark = "F";
            }
            Console.WriteLine($"[{student.Course} - course] {student.Name} - {mark}");
        }
    }
}