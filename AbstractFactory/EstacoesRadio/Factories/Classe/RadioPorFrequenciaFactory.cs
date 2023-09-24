using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Factories.Interface;
using AbstractFactory.EstacoesRadio.Frequencia;

namespace AbstractFactory.EstacoesRadio.Factories.Classe
{
	internal class RadioPorFrequenciaFactory : IRadioPorFrequenciaFactory
	{
		public IRadioPorFrequencia CriarRadioPorFrequencia(TipoDeFrequencia tipoDeFrequencia)
		{
			return tipoDeFrequencia switch
			{
				TipoDeFrequencia.AM => new RadioAm(),
				TipoDeFrequencia.FM => new RadioFm(),
				_ => new RadioAm(),
			};
		}
	}
}
