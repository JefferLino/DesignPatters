using AbstractFactory.JogoRpg.Enemies.Horda;
using AbstractFactory.JogoRpg.Enemies.Interface;
using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;

namespace AbstractFactory.JogoRpg.Factories.Classes.Horda
{
    internal class EnemieHordaPlayer : IEnemieFactory
    {
        public IEnemie CreateEnemie(EnumEnemies tipoEnemie)
        {
            return tipoEnemie switch
            {
                EnumEnemies.GLOBIN => new Globin(),
                EnumEnemies.ORC => new Orc(),
                _ => new Globin(),
            };
        }
    }
}
