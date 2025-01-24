namespace Dependency_Inversion.BadExample;

public class FileLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}