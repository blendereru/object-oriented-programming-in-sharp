using Builder.Product;

namespace Builder.Builder;

public class DoubleCheeseBurgerBuilder : BurgerBuilder
{
    private readonly Burger _burger = new Burger();
    public override void PreparePatty()
    {
        _burger.NumberOfPatties = 2;
    }

    public override void PrepareLettuce()
    {
        _burger.HasCucumber = _burger.HasTomato = true;
    }

    public override void PrepareSauces()
    {
        _burger.Sauces.Add("Ketchup");
        _burger.Sauces.Add("Cheese");
    }

    public override Burger GetBurger()
    {
        return _burger;
    }
}