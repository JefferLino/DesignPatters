using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Factories.Interface;
using AbstractFactory.EstacoesRadio.Frequencia;

namespace AbstractFactory.EstacoesRadio.CriarRadio
{
	internal class RadioPorFrequenciaApplication
	{
		private readonly IRadioPorFrequencia radioPorFrequencia;

		public RadioPorFrequenciaApplication(IRadioPorFrequenciaFactory radioPorFrequenciaFactory, TipoDeFrequencia tipoDeFrequencia)
		{
			radioPorFrequencia = radioPorFrequenciaFactory.CriarRadioPorFrequencia(tipoDeFrequencia);
		}

		public void IniciarTocadorDeMusicaPorFrequencia()
			=> radioPorFrequencia.TocarMusica();

		public void IniciarTocadorDePropagandaPorFrequencia()
			=> radioPorFrequencia.TocarPropaganda();

		public void IniciarVozDoBrasil()
			=> radioPorFrequencia.TocarVozDoBrasil();
	}
}
