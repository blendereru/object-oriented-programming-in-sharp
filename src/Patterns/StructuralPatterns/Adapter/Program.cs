using Adapter;

var client = new PrinterClient();
IPrinter laserPrinter = new LaserPrinterAdapter();
client.PrintDocument(laserPrinter, "temp.doc");
IPrinter thermalPrinter = new ThermalPrinterAdapter();
client.PrintDocument(thermalPrinter, "another.doc");