using Strategy.Interface;

namespace Strategy.Context;

public class TransportContext
{
    public void UseTransportType(IMovable movable)
    {
        movable.Move();
    }
}