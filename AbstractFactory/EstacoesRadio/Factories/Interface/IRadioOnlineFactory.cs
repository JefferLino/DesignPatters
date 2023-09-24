using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Online;

namespace AbstractFactory.EstacoesRadio.Factories.Interface
{
	internal interface IRadioOnlineFactory
	{
		IRadioOnline CriarRadioOnline(TipoDaRadio tipoDaRadio);
	}
}
