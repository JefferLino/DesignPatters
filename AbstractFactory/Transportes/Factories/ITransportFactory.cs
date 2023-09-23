using AbstractFactory.Tranportes.Aircrafts;
using AbstractFactory.Tranportes.Landvehicles;

namespace AbstractFactory.Tranportes.Factories
{
    internal interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();

        ILandvehicle CreateTransportVehicle();
    }
}
