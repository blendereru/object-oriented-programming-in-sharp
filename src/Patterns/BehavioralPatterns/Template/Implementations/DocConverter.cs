using Template.TemplateClass;

namespace Template.Implementations;

public class DocConverter : Converter
{
    protected override void ReadContent()
    {
        Console.WriteLine("Reading context of the file.");
    }

    protected override void CreateTargetFormat()
    {
        Console.WriteLine("Creating the doc extension file.");
    }

    protected override void WriteContentToTargetFormat()
    {
        Console.WriteLine("Writing the content of the file to the doc file created.");
    }
}