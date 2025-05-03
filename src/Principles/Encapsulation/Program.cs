using Encapsulation;

Teacher mathTeacher = new Teacher("Mrs.Anne", "Math");
var firstStudent = new Student("Andrew", 3);
var secondStudent = new Student("Matt", 2);
var thirdStudent = new Student("Sara", 1);
var fourthStudent = new Student("Derrick", 3);
var fifthStudent = new Student("John", 2);
mathTeacher.AddStudent(firstStudent);
mathTeacher.AddStudent(secondStudent);
mathTeacher.AddStudent(thirdStudent);
mathTeacher.AddStudent(fourthStudent);
mathTeacher.AddStudent(fifthStudent);
mathTeacher.PutMark(firstStudent, "A");
mathTeacher.PutMark(secondStudent, "C");
mathTeacher.PutMark(thirdStudent, "B");
mathTeacher.PutMark(fourthStudent, "F");
mathTeacher.ShowMarks();