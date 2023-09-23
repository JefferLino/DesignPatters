using AbstractFactory.Landvehicles;
using AbstractFactory.Tranportes.Aircrafts;
using AbstractFactory.Tranportes.Landvehicles;

namespace AbstractFactory.Tranportes.Factories
{
    internal class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Patinete();
        }
    }
}
