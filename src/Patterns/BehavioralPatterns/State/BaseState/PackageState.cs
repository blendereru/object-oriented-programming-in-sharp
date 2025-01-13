using State.Context;

namespace State.BaseState;

public abstract class PackageState
{
    public abstract void ProceedToNextState(PackageContext context);
    public abstract void PrintStatus();
}