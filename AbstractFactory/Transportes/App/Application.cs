using AbstractFactory.Tranportes.Aircrafts;
using AbstractFactory.Tranportes.Factories;
using AbstractFactory.Tranportes.Landvehicles;

namespace AbstractFactory.Tranportes.App
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
