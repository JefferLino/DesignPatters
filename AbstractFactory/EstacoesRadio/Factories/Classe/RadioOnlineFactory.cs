using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Factories.Interface;
using AbstractFactory.EstacoesRadio.Online;

namespace AbstractFactory.EstacoesRadio.Factories.Classe
{
	internal class RadioOnlineFactory : IRadioOnlineFactory
	{
		public IRadioOnline CriarRadioOnline(TipoDaRadio tipoDaRadio)
		{
			return tipoDaRadio switch
			{
				TipoDaRadio.ROCK => new Rock(),
				TipoDaRadio.SERTANEJO => new Sertanejo(),
				TipoDaRadio.GOSPEL => new Gospel(),
				_ => new Rock(),
			};
		}
	}
}
