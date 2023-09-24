using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Factories.Interface;
using AbstractFactory.EstacoesRadio.Frequencia;
using AbstractFactory.EstacoesRadio.Online;

namespace AbstractFactory.EstacoesRadio.CriarRadio
{
	internal class RadioOnlineApplication
	{
		private readonly IRadioOnline radioOnline;

		public RadioOnlineApplication(IRadioOnlineFactory radioOnlineFactory, TipoDaRadio tipoDaRadio)
		{
			radioOnline = radioOnlineFactory.CriarRadioOnline(tipoDaRadio);
		}

		public void IniciarTocadarDeMusicaOnline() 
			=> radioOnline.TocarMusica();

		public void IniciarTocadorDePropagandaOnline()
			=> radioOnline.TocarPropaganda();
	}
}
