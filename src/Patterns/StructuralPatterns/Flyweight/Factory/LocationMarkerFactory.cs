using Flyweight.BaseClasses;
using Flyweight.Implementations;

namespace Flyweight.Factory;

public class LocationMarkerFactory
{
    private readonly Dictionary<MarkerType, ILocationMarker> _locationMarkers = new Dictionary<MarkerType, ILocationMarker>();

    public ILocationMarker GetMarker(MarkerType markerType)
    {
        if (!_locationMarkers.ContainsKey(markerType))
        {
            switch (markerType)
            {
                case MarkerType.Hospital:
                    _locationMarkers.Add(MarkerType.Hospital, new HospitalMarker("[Hospital Icon]"));
                    break;
                default:
                    _locationMarkers.Add(MarkerType.Restaurant, new HospitalMarker("[Hospital Icon]"));
                    break;
            }
        }
        return _locationMarkers[markerType];
    }
}