using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
	internal interface ITransportFactory
	{
		IAircraft CreateTransportAircraft();

		ILandvehicle CreateTransportVehicle();
	}
}
