using Builder.Builder;
using Builder.Director;

var cooker = new Cooker();
var doubleCheeseBurger = new DoubleCheeseBurgerBuilder();
cooker.MakeBurger(doubleCheeseBurger);