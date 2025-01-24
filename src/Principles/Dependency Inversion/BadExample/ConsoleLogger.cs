namespace Dependency_Inversion.BadExample;

public class ConsoleLogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}