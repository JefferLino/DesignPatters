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
			var heroAlianca = StartGameHeroPlayer(EnumHeros.DRUID, EnumFaccao.ALIANCA);
			var heroHorda = StartGameHeroPlayer(EnumHeros.DWARF, EnumFaccao.HORDA);

			heroAlianca.ExecuteAttack();
			heroAlianca.ExecuteDefense();

			heroHorda.ExecuteAttack();
			heroHorda.ExecuteDefense();

			var enimieAlianca = StartGameEnemiePlayer(EnumEnemies.LADINO, EnumFaccao.ALIANCA);
			var enimieHorada = StartGameEnemiePlayer(EnumEnemies.GLOBIN, EnumFaccao.HORDA);

			enimieAlianca.ExecuteAttack();
			enimieAlianca.ExecuteDefense();

			enimieHorada.ExecuteAttack();
			enimieHorada.ExecuteDefense();

			Console.ReadLine();
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