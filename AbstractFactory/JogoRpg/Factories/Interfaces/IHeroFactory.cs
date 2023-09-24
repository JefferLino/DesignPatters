using AbstractFactory.JogoRpg.Enumeradores;
using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Factories.Interfaces
{
    internal interface IHeroFactory
    {
		IHero CreateHero(EnumHeros tipoHero);
	}
}
