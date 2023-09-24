using AbstractFactory.JogoRpg.Enemies.Interface;
using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;

namespace AbstractFactory.JogoRpg.StartGame
{
	internal class StartGameEnemiePlayer
	{
		private readonly IEnemie enemie;

		public StartGameEnemiePlayer(IEnemieFactory enemieFactory, EnumEnemies tipoEnemie)
		{
			enemie = enemieFactory.CreateEnemie(tipoEnemie);
		}

		public void ExecuteAttack()
		{
			enemie.Attack();
		}

		public void ExecuteDefense()
		{
			enemie.Defend();
		}
	}
}
