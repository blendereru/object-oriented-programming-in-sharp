namespace Adapter;

public class PrinterClient
{
    public void PrintDocument(IPrinter printer, string document)
    {
        printer.Print(document);
    }
}
