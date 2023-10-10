namespace Builder.Casas.Components
{
	internal class Jardim
	{
		private double metrosQuadrados;
		private string tipoDaGrama;
		private int quantidadeDePlantas;

		public Jardim(double metrosQuadrados, string tipoDaGrama, int quantidadeDePlantas)
		{
			MetrosQuadrados = metrosQuadrados;
			TipoDaGrama = tipoDaGrama;
			QuantidadeDePlantas = quantidadeDePlantas;
		}

		public double MetrosQuadrados
		{ 
			get => metrosQuadrados;
			set => metrosQuadrados = value;
		}

		public string TipoDaGrama
		{ 
			get => tipoDaGrama;
			set => tipoDaGrama = value;
		}

		public int QuantidadeDePlantas
		{ 
			get => quantidadeDePlantas;
			set => quantidadeDePlantas = value;
		}
	}
}
