using Observer.Implementations;
using Observer.Models;

var productStock = new ProductStock();
var product = new Product() { ProductName = "Dumbbels" };
productStock.Add(product);
Observer.BaseClasses.Observer observer = new User() {Name = "Michael", DesiredProductName = "Dumbbels"};
productStock.RegisterObserver(observer);
productStock.NotifyObservers(product);