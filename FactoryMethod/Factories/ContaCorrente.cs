using FactoryMethod.Contas;

namespace FactoryMethod.Factories
{
	internal class ContaCorrente : Conta
	{
		protected override IContaPadrao CriarConta()
		{
			return new Corrente();
		}
	}
}
