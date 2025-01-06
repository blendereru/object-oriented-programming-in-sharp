using Builder.Builder;

namespace Builder.Director;

public class Cooker
{
    public void MakeBurger(BurgerBuilder burgerBuilder)
    {
        burgerBuilder.PrepareLettuce();
        burgerBuilder.PrepareSauces();
        burgerBuilder.PreparePatty();
        var burger = burgerBuilder.GetBurger();
        Console.WriteLine($"The burger contains the following ingredients: 2 breads, {Convert.ToInt32(burger.HasTomato)} tomatoes, {Convert.ToInt32(burger.HasCucumber)} cucumbers, {string.Join(", ", burger.Sauces)}, {burger.NumberOfPatties}");
    }
}