using FactoryMethod.Contas;

namespace FactoryMethod.Factories
{
	internal class ContaPoupanca : Conta
	{
		protected override IContaPadrao CriarConta()
		{
			return new Poupanca();
		}
	}
}
