namespace Abstraction;
public class LocalDisk : IFileStorage
{
    private readonly string _destinationDirectory;

    public LocalDisk(string destinationDirectory)
    {
        _destinationDirectory = destinationDirectory;
    }

    public Task Save(params FileInfo[] files)
    {
        foreach (var file in files)
        {
            Directory.CreateDirectory(_destinationDirectory);
            var destinationPath = Path.Combine(_destinationDirectory, file.Name);
            file.CopyTo(destinationPath, overwrite: true);
        }
        Console.WriteLine("Files saved to local disk...");
        return Task.CompletedTask;
    }
}
