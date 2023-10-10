using AbstractFactory.EstacoesRadio.CriarRadio;
using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Factories.Classe;
using AbstractFactory.EstacoesRadio.Factories.Interface;
using AbstractFactory.EstacoesRadio.Online;
using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Classes.Alianca;
using AbstractFactory.JogoRpg.Factories.Classes.Horda;
using AbstractFactory.JogoRpg.Factories.Interfaces;
using AbstractFactory.JogoRpg.StartGame;

namespace AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//var radioOnlineGospel = GetRadioOnlineApplication(TipoDaRadio.GOSPEL);

			//radioOnlineGospel.IniciarTocadarDeMusicaOnline();
			//radioOnlineGospel.IniciarTocadorDePropagandaOnline();

			//var radioOnlineSertanejo = GetRadioOnlineApplication(TipoDaRadio.SERTANEJO);

			//radioOnlineSertanejo.IniciarTocadarDeMusicaOnline();
			//radioOnlineSertanejo.IniciarTocadorDePropagandaOnline();

			var radioOnlineRock = GetRadioOnlineApplication(TipoDaRadio.ROCK);

			radioOnlineRock.IniciarTocadarDeMusicaOnline();
			radioOnlineRock.IniciarTocadorDePropagandaOnline();

			var radioFm = GetRadioPorFrequenciaApplication(TipoDeFrequencia.FM);

			radioFm.IniciarTocadorDeMusicaPorFrequencia();
			radioFm.IniciarTocadorDePropagandaPorFrequencia();

			var radioAm = GetRadioPorFrequenciaApplication(TipoDeFrequencia.AM);

			radioAm.IniciarTocadorDeMusicaPorFrequencia();
			radioAm.IniciarTocadorDePropagandaPorFrequencia();

			//var heroAlianca = StartGameHeroPlayer(EnumHeros.DRUID, EnumFaccao.ALIANCA);
			//var heroHorda = StartGameHeroPlayer(EnumHeros.DWARF, EnumFaccao.HORDA);

			//heroAlianca.ExecuteAttack();
			//heroAlianca.ExecuteDefense();

			//heroHorda.ExecuteAttack();
			//heroHorda.ExecuteDefense();

			//var enimieAlianca = StartGameEnemiePlayer(EnumEnemies.LADINO, EnumFaccao.ALIANCA);
			//var enimieHorada = StartGameEnemiePlayer(EnumEnemies.GLOBIN, EnumFaccao.HORDA);

			//enimieAlianca.ExecuteAttack();
			//enimieAlianca.ExecuteDefense();

			//enimieHorada.ExecuteAttack();
			//enimieHorada.ExecuteDefense();

			Console.ReadLine();
		}

		static RadioOnlineApplication GetRadioOnlineApplication(TipoDaRadio tipoDaRadio)
		{
			IRadioOnlineFactory radioOnlineFactory = new RadioOnlineFactory();

			return new RadioOnlineApplication(radioOnlineFactory, tipoDaRadio);
		}

		static RadioPorFrequenciaApplication GetRadioPorFrequenciaApplication(TipoDeFrequencia tipoDeFrequencia)
		{
			IRadioPorFrequenciaFactory radioPorFrequenciaFactory = new RadioPorFrequenciaFactory();

			return new RadioPorFrequenciaApplication(radioPorFrequenciaFactory, tipoDeFrequencia);
		}

		static StartGameHeroPlayer StartGameHeroPlayer(EnumHeros hero, EnumFaccao faccao)
		{
			IHeroFactory heroFactory = faccao switch
			{
				EnumFaccao.ALIANCA => new HeroAliancaPlayer(),
				EnumFaccao.HORDA => new HeroHordaPlayer(),
				_ => new HeroAliancaPlayer(),
			};

			return new StartGameHeroPlayer(heroFactory, hero);
		}

		static StartGameEnemiePlayer StartGameEnemiePlayer(EnumEnemies enemie, EnumFaccao faccao)
		{
			IEnemieFactory enemieFactory = faccao switch
			{
				EnumFaccao.ALIANCA => new EnemieAliancaPlayer(),
				EnumFaccao.HORDA => new EnemieHordaPlayer(),
				_ => new EnemieAliancaPlayer(),
			};

			return new StartGameEnemiePlayer(enemieFactory, enemie);
		}
	}
}