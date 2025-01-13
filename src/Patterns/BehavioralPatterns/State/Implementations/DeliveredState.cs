using State.BaseState;
using State.Context;

namespace State.Implementations;

public class DeliveredState : PackageState
{
    public override void PrintStatus()
    {
        Console.WriteLine("The package is currently at DELIVERED state");
    }

    public override void ProceedToNextState(PackageContext context)
    {
        Console.WriteLine("The package is already delivered. No state to transition to.");
    }
}