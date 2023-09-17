using FactoryMethod.Contas;

namespace FactoryMethod.Factories
{
	internal class ContaSalario : Conta
	{
		protected override IContaPadrao CriarConta()
		{
			return new Salario();
		}
	}
}
