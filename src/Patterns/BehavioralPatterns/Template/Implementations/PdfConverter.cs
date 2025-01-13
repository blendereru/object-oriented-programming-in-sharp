using Template.TemplateClass;

namespace Template.Implementations;

public class PdfConverter : Converter
{
    protected override void ReadContent()
    {
        Console.WriteLine("Reading context of the file.");
    }

    protected override void CreateTargetFormat()
    {
        Console.WriteLine("Creating the pdf extension file.");
    }

    protected override void WriteContentToTargetFormat()
    {
        Console.WriteLine("Writing the content of the file to the pdf file created.");
    }
}