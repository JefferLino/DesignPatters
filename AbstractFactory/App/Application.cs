using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
	internal class Application
	{
		private readonly IAircraft aircraft;
		private readonly ILandvehicle vehicle;

		public Application(ITransportFactory factory)
		{
			aircraft = factory.CreateTransportAircraft();
			vehicle = factory.CreateTransportVehicle();
		}

		public void StartRoute() 
		{
			aircraft.StarRoute();
			vehicle.StarRoute();
		}
	}
}
