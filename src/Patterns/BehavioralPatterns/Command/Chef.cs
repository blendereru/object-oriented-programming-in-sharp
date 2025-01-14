namespace Command;

public class Chef
{
    public void PreparePizza()
    {
        Console.WriteLine("Chef is preparing pizza");
    }

    public void CancelPizzaPreparation()
    {
        Console.WriteLine("Chef has cancelled the pizza preparation");
    }
    public void PrepareFries()
    {
        Console.WriteLine("Chef is preparing fries");
    }

    public void CancelFriesPreparation()
    {
        Console.WriteLine("Chef has cancelled the fries' preparation");
    }
}