using Iterator.Implementations;

var course = new Course();
var student1 = new Student() { Name = "Andrew" };
var student2 = new Student() { Name = "Josh" };
course.AddStudent(student1);
course.AddStudent(student2);
var university = new University();
university.DisplayStudents(course);
