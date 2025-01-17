namespace Adapter;

public class ThermalPrinterAdapter : IPrinter
{
    private readonly ThermalPrinter _thermalPrinter = new();

    public void Print(string document)
    {
        _thermalPrinter.PrintThermal(document);
    }
}
