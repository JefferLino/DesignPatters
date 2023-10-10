namespace Builder.Veiculos.Components
{
	internal class Engine
	{
		private int power;

		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		public Engine(int power)
		{
			Power = power;
		}
	}
}
