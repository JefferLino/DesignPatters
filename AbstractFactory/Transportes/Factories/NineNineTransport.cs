using AbstractFactory.Landvehicles;
using AbstractFactory.Tranportes.Aircrafts;
using AbstractFactory.Tranportes.Landvehicles;

namespace AbstractFactory.Tranportes.Factories
{
    internal class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Motorcycle();
        }
    }
}
