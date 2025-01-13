using State.BaseState;
using State.Implementations;

namespace State.Context;

public class PackageContext
{
    private PackageState _state;
    public PackageContext()
    {
        _state = new OrderedState();
    }

    public void PrintStatus()
    {
        _state.PrintStatus();
    }
    public void SetState(PackageState state)
    {
        _state = state;
        
    }
    public void ProceedToNextState()
    {
        _state.ProceedToNextState(this);
    }
}