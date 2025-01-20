using Composite;

var folder = new Folder("api");
var controllerFolder = new Folder("Controller");
folder.Add(controllerFolder);
Console.WriteLine("Root Folder:");
folder.Add(new Composite.File("appsettings.json"));
controllerFolder.Add(new Composite.File("HomeController.cs"));
controllerFolder.Add(new Composite.File("AccountController.cs"));
Console.WriteLine("api Folder:");
folder.Display();
Console.WriteLine("________________________");
Console.WriteLine("Controller folder: ");
controllerFolder.Display();
