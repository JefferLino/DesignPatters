using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Factories.Interfaces;
using AbstractFactory.JogoRpg.Heroes.Horda;
using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Factories.Classes.Horda
{
    internal class HeroHordaPlayer : IHeroFactory
    {
        public IHero CreateHero(EnumHeros tipoHero)
        {
            return tipoHero switch
            {
                EnumHeros.DWARF => new Dwarf(),
                _ => new Dwarf(),
            };
        }
    }
}
