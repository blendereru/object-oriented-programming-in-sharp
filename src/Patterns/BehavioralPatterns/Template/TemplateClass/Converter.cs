namespace Template.TemplateClass;

public abstract class Converter
{
    public void Convert(string path)
    {
        OpenFile(path);
        ReadContent();
        CreateTargetFormat();
        WriteContentToTargetFormat();
    }

    private void OpenFile(string path)
    {
        Console.WriteLine($"Opening the file by path: {path}");
    }

    protected abstract void ReadContent();
    protected abstract void CreateTargetFormat();
    protected abstract void WriteContentToTargetFormat();
}