using State.BaseState;
using State.Context;

namespace State.Implementations;

public class OrderedState : PackageState
{
    public override void PrintStatus()
    {
        Console.WriteLine("The package is currently at ORDERED state");
    }

    public override void ProceedToNextState(PackageContext context)
    {
        context.SetState(new ShippedState());
    }
}