namespace AbstractFactory.Landvehicles
{
	internal class Car : ILandvehicle
	{
		public void GetCargo()
		{
			Console.WriteLine("Pegamos os passageiros, estamos prontos!");
		}

		public void StarRoute()
		{
			GetCargo();
			Console.WriteLine("Iniciando trajeto!");
		}
	}
}
