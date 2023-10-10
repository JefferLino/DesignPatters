using Builder.Casas.Components;
using Builder.Casas.Products;

namespace Builder.Casas.Builders
{
	internal interface IBuilder
	{
		void Reset();

		Casa ObterCasa();

		CasaBuilder DefinirQuantidadeDeQuartosDaCasa(int quantidadeDeQuartos);

		CasaBuilder DefinirQuantidadeDeComodosDaCasa(int quantidadeDeComodos);

		CasaBuilder DefinirCorDaCasa(string corDaCasa);

		CasaBuilder DefinirTipoDaCasa(TipoDaCasa tipoDaCasa);

		CasaBuilder DefinirJardimDaCasa(Jardim jardim);

		CasaBuilder DefinirPiscinaDaCasa(Piscina piscina);
	}
}
