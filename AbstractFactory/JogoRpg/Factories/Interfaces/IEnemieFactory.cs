using AbstractFactory.JogoRpg.Enemies.Interface;
using AbstractFactory.JogoRpg.Enumeradores;

namespace AbstractFactory.JogoRpg.Factories.Interfaces
{
    internal interface IEnemieFactory
	{
		IEnemie CreateEnemie(EnumEnemies tipoEnemie);
	}
}
