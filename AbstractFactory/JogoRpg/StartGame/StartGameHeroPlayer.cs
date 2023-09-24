using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;
using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.StartGame
{
    internal class StartGameHeroPlayer
	{
		private readonly IHero hero;

		public StartGameHeroPlayer(IHeroFactory heroFactory, EnumHeros tipoHero)
		{
			hero = heroFactory.CreateHero(tipoHero);
		}

		public void ExecuteAttack()
		{
			hero.Attack();
		}

		public void ExecuteDefense()
		{
			hero.Defend();
		}
	}
}
