using Command;

var chef = new Chef();
var pizza = new PizzaOrderCommand(chef);
var fries = new FriesOrderCommand(chef);
var waiter = new Waiter();
waiter.TakeOrder(pizza);
waiter.TakeOrder(fries);
waiter.PlaceOrders();
waiter.CancelOrder(pizza);