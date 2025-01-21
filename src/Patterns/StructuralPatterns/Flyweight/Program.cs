using Flyweight;
using Flyweight.Factory;

var markerFactory = new LocationMarkerFactory();
var hospitalMarker = markerFactory.GetMarker(MarkerType.Hospital);
hospitalMarker.Display(40, 50);
var restaurantMarker = markerFactory.GetMarker(MarkerType.Restaurant);
restaurantMarker.Display(30, 20);
var newHospitalMarker = markerFactory.GetMarker(MarkerType.Hospital);
newHospitalMarker.Display(23, 47);