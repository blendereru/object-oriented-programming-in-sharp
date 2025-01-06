using AbstractFactory.Factories;

var courseFactory = new BackendCourseFactory();
var javaCourse = courseFactory.CreateJavaCourse();
javaCourse.ShowCourseDefinition();