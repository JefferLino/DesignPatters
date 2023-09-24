using AbstractFactory.JogoRpg.Enemies.Alianca;
using AbstractFactory.JogoRpg.Enemies.Interface;
using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;

namespace AbstractFactory.JogoRpg.Factories.Classes.Alianca
{
    internal class EnemieAliancaPlayer : IEnemieFactory
    {
        public IEnemie CreateEnemie(EnumEnemies tipoEnemie)
        {
            return tipoEnemie switch
            {
                EnumEnemies.LADINO => new Ladino(),
                _ => new Ladino(),
            };
        }
    }
}
