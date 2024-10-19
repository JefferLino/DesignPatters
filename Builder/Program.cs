using Builder.Casas.Builders;
using Builder.Casas.Components;
using Builder.Jogos.MedalOfHonor.Classes;
using Builder.Jogos.MedalOfHonor.Fabrica;

namespace Builder
{
    internal class Program
	{
		static void Main(string[] args)
		{
			var exercito = new Exercito();
			CriadorDeSoldado criadorDeSoldado;
			Soldado soldado;

			criadorDeSoldado = new CriadorForcasEspeciais();
			exercito.ConstruirSoldado(criadorDeSoldado);

			soldado = criadorDeSoldado.ObterSoldado();

            Console.WriteLine("Soldado com as características: {0}, {1}, {2}",soldado.Arma, soldado.Transporte, soldado.Foco);

            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);

            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado com as características: {0}, {1}, {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            //var casaPadrao = new CasaBuilder()
            //					 .DefinirCorDaCasa("Azul")
            //					 .DefinirQuantidadeDeQuartosDaCasa(5)
            //					 .DefinirQuantidadeDeComodosDaCasa(7)
            //					 .DefinirTipoDaCasa(TipoDaCasa.PADRAO)
            //					 .ObterCasa();

            //Console.WriteLine($"Criado uma casa padrão na cor {casaPadrao.CorDaCasa} e com {casaPadrao.QuantidadeDeQuartos} quartos e {casaPadrao.QuantidadeDeComodos} comodos!");

            //var casaPadraoComJardim = new CasaBuilder()
            //					          .DefinirCorDaCasa("Verde")
            //					          .DefinirQuantidadeDeQuartosDaCasa(3)
            //					          .DefinirQuantidadeDeComodosDaCasa(5)
            //					          .DefinirTipoDaCasa(TipoDaCasa.PADRAO)
            //							  .DefinirJardimDaCasa(new Jardim(15, "Esmeralda", 20))
            //					          .ObterCasa();

            //Console.WriteLine($"Criado uma casa padrão na cor {casaPadraoComJardim.CorDaCasa} e com {casaPadraoComJardim.QuantidadeDeQuartos} quartos e {casaPadraoComJardim.QuantidadeDeComodos} " +
            //	              $"comodos e com jardim de {casaPadraoComJardim.Jardim.MetrosQuadrados} metros quadrados!");

            //var casaPadraoComJardimEhPisicina = new CasaBuilder()
            //							           .DefinirCorDaCasa("Verde")
            //							           .DefinirQuantidadeDeQuartosDaCasa(3)
            //							           .DefinirQuantidadeDeComodosDaCasa(5)
            //							           .DefinirTipoDaCasa(TipoDaCasa.PADRAO)
            //							           .DefinirJardimDaCasa(new Jardim(15, "Esmeralda", 20))
            //									   .DefinirPiscinaDaCasa(new Piscina(1500, true))
            //							           .ObterCasa();

            //Console.WriteLine($"Criado uma casa padrão na cor {casaPadraoComJardimEhPisicina.CorDaCasa} e com {casaPadraoComJardimEhPisicina.QuantidadeDeQuartos} quartos e {casaPadraoComJardimEhPisicina.QuantidadeDeComodos} " +
            //				  $"comodos e com jardim de {casaPadraoComJardimEhPisicina.Jardim.MetrosQuadrados} metros quadrados e com piscina de {casaPadraoComJardimEhPisicina.Piscina.Litragem} litros!");

            //var builder = new VehicleBuilder();
            //var director = new Director(builder);

            //director.ConstructSedanCar();

            //var sedan = builder.GetVehicle();

            //Console.WriteLine($"Criado um veículo do tipo: {sedan.VehicleType}");

            //director.ConstructSedanTruck();

            //var truck = builder.GetVehicle();

            //Console.WriteLine($"Criado um caminhão do tipo: {truck.VehicleType}");
        }
	}
}