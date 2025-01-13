using Template.Implementations;
using Template.TemplateClass;

Converter converter = new PdfConverter();
converter.Convert(@"C:/Program Files/temp.txt");
Console.WriteLine("____________");
converter = new DocConverter();
converter.Convert(@"C:/Program Files/temp.txt");