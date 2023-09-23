namespace AbstractFactory.Landvehicles
{
	internal class Motorcycle : ILandvehicle
	{
		public void GetCargo()
		{
			Console.WriteLine("Pegamos a encomenda!");
		}

		public void StarRoute()
		{
			GetCargo();
			Console.WriteLine("Iniciando a entrega!");
		}
	}
}
