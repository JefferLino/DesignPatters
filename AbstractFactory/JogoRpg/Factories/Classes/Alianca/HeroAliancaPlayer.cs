using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;
using AbstractFactory.JogoRpg.Heroes.Alianca;
using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Factories.Classes.Alianca
{
    internal class HeroAliancaPlayer : IHeroFactory
    {
        public IHero CreateHero(EnumHeros tipoHero)
        {
            return tipoHero switch
            {
                EnumHeros.DRUID => new Druid(),
                EnumHeros.MAGE => new Mage(),
                _ => new Druid(),
            };
        }
    }
}
