using Prototype;
var circle = new Circle() {Radius = 5};
Console.WriteLine(circle.GetArea());
var newCircle = circle.Clone() as Circle;
newCircle.Radius = 7;
Console.WriteLine(newCircle.GetArea());