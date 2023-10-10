using Builder.Veiculos.Builders;
using Builder.Veiculos.Components;

namespace Builder.Veiculos.Directors
{
	internal class Director
	{
		private readonly IBuilder _builder;

		public Director(IBuilder builder)
		{
			_builder = builder;
		}

		public void ConstructSedanCar() 
		{
			_builder.SetVehicleType(VehicleType.SEDAN);
			_builder.SetEngine(new Engine(5000));
			_builder.SetSeats(4);
			_builder.SetTransmission(Transmission.AUTOMATIC);
		}

		public void ConstructSedanTruck()
		{
			_builder.SetVehicleType(VehicleType.TRUCK);
			_builder.SetEngine(new Engine(2000));
			_builder.SetSeats(5);
			_builder.SetTransmission(Transmission.MANUAL);
		}
	}
}
