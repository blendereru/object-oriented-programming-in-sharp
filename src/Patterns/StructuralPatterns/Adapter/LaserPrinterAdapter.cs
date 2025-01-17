namespace Adapter;

public class LaserPrinterAdapter : IPrinter
{
    private readonly LaserPrinter _laserPrinter = new();

    public void Print(string document)
    {
        _laserPrinter.StartLaserPrint(document);
    }
}
