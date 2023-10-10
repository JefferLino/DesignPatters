using Builder.Casas.Components;

namespace Builder.Casas.Products
{
	internal class Casa
	{
		private int quantidadeDeQuartos;
		private int quantidadeDeComodos;
		private string corDaCasa;
		private TipoDaCasa tipoDaCasa;
		private Jardim jardim;
		private Piscina piscina;

		public int QuantidadeDeQuartos
		{ 
			get => quantidadeDeQuartos;
			set => quantidadeDeQuartos = value; 
		}

		public int QuantidadeDeComodos
		{ 
			get => quantidadeDeComodos;
			set => quantidadeDeComodos = value;
		}

		public string CorDaCasa
		{ 
			get => corDaCasa;
			set => corDaCasa = value;
		}

		public TipoDaCasa TipoDaCasa
		{  
			get => tipoDaCasa;
			set => tipoDaCasa = value; 
		}

		public Jardim Jardim
		{ 
			get => jardim;
			set => jardim = value;
		}

		public Piscina Piscina
		{  
			get => piscina;
			set => piscina = value;
		}
	}
}
