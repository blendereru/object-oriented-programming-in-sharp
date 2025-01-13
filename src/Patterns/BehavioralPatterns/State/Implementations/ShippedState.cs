using State.BaseState;
using State.Context;

namespace State.Implementations;

public class ShippedState : PackageState
{
    public override void PrintStatus()
    {
        Console.WriteLine("The package is currently at SHIPPED state");
    }

    public override void ProceedToNextState(PackageContext context)
    {
        context.SetState(new DeliveredState());
    }
}