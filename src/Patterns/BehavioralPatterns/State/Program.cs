using State.Context;

var package = new PackageContext();
package.PrintStatus();
package.ProceedToNextState();
Console.WriteLine("_____________________________________________________");
package.PrintStatus();
package.ProceedToNextState();
Console.WriteLine("_____________________________________________________");
package.PrintStatus();
package.ProceedToNextState();