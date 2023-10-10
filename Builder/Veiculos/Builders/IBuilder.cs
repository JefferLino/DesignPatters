using Builder.Veiculos.Components;
using Builder.Veiculos.Products;

namespace Builder.Veiculos.Builders
{
	internal interface IBuilder
	{
		void Reset();

		Vehicle GetVehicle();

		void SetSeats(int seats);

		void SetEngine(Engine engine);

		void SetTransmission(Transmission transmission);

		void SetVehicleType(VehicleType vehicleType);
	}
}
