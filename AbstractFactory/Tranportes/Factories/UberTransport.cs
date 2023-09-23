using AbstractFactory.Tranportes.Aircrafts;
using AbstractFactory.Tranportes.Landvehicles;

namespace AbstractFactory.Tranportes.Factories
{
    internal class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandvehicle CreateTransportVehicle()
        {
            return new Car();
        }
    }
}
