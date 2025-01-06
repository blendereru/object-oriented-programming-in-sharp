using Builder.Product;

namespace Builder.Builder;

public abstract class BurgerBuilder
{
    public abstract void PrepareLettuce();
    public abstract void PrepareSauces();
    public abstract void PreparePatty();
    public abstract Burger GetBurger();
}