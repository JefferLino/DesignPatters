namespace Builder.Casas.Components
{
	internal class Piscina
	{
		private double litragem;
		private bool ehPorcelanato;

		public Piscina(double litragem, bool ehPorcelanato)
		{
			Litragem = litragem;
			EhPorcelanato = ehPorcelanato;
		}

		public double Litragem
		{ 
			get => litragem;
			set => litragem = value;
		}

		public bool EhPorcelanato
		{ 
			get => ehPorcelanato;
			set => ehPorcelanato = value;
		}
	}
}
