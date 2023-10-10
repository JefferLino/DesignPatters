using Builder.Casas.Components;
using Builder.Casas.Products;

namespace Builder.Casas.Builders
{
	internal class CasaBuilder : IBuilder
	{
		private Casa casa = new Casa();

		public CasaBuilder DefinirCorDaCasa(string corDaCasa)
		{
			casa.CorDaCasa = corDaCasa;
			return this;
		}

		public CasaBuilder DefinirJardimDaCasa(Jardim jardim)
		{
			casa.Jardim = jardim;
			return this;
		}

		public CasaBuilder DefinirPiscinaDaCasa(Piscina piscina)
		{
			casa.Piscina = piscina;
			return this;
		}

		public CasaBuilder DefinirQuantidadeDeComodosDaCasa(int quantidadeDeComodos)
		{
			casa.QuantidadeDeComodos = quantidadeDeComodos;
			return this;
		}

		public CasaBuilder DefinirQuantidadeDeQuartosDaCasa(int quantidadeDeQuartos)
		{
			casa.QuantidadeDeQuartos = quantidadeDeQuartos;
			return this;
		}

		public CasaBuilder DefinirTipoDaCasa(TipoDaCasa tipoDaCasa)
		{
			casa.TipoDaCasa = tipoDaCasa;
			return this;
		}

		public Casa ObterCasa()
		{
			Casa result = casa;
			Reset();
			return result;
		}

		public void Reset()
		{
			casa = new Casa();
		}
	}
}
