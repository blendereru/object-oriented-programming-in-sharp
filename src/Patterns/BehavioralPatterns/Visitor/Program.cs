using Visitor;
using Visitor.BaseClasses;
using Visitor.Implementations;

var elements = new Elements();
elements.Add(new Circle(5));
elements.Add(new Circle(8));
elements.Add(new Rectangle(7, 8));
var perimeterVisitor = new PerimeterVisitor();
var areaVisitor = new AreaVisitor();
elements.Accept(perimeterVisitor);
elements.Accept(areaVisitor);