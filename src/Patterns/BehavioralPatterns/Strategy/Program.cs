using Strategy.Context;
using Strategy.Implementations;
using Strategy.Interface;

var context = new TransportContext();
IMovable movable = new Bus();
context.UseTransportType(movable);
