namespace AbstractFactory.Aircrafts
{
	internal class Drone : IAircraft
	{
		public void CheckWind()
		{
			Console.WriteLine("Verificando os ventos, ventos a 5km, ventos ok!");
		}

		public void GetCargo()
		{
			Console.WriteLine("Encomenda inserida no drone, voô autorizado!");
		}

		public void StarRoute()
		{
			CheckWind();
			GetCargo();
			Console.WriteLine("Iniciando decolagem com o drone!");
		}
	}
}
