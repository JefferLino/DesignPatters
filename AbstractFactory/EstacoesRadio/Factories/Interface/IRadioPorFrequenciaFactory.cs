using AbstractFactory.EstacoesRadio.Enumeradores;
using AbstractFactory.EstacoesRadio.Frequencia;

namespace AbstractFactory.EstacoesRadio.Factories.Interface
{
	internal interface IRadioPorFrequenciaFactory
	{
		IRadioPorFrequencia CriarRadioPorFrequencia(TipoDeFrequencia tipoDeFrequencia);
	}
}
