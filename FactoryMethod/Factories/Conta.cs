using FactoryMethod.Contas;

namespace FactoryMethod.Factories
{
	abstract class Conta
	{
		private readonly IContaPadrao conta;

		public Conta()
		{
			conta = CriarConta();
		}

		public void RealizarAbertura() 
		{
			conta.NovaConta();
		}

		public void RealizarDebito(double valor)
		{
			conta.DebitarSaldo(valor);
		}

		public void RealizarCredito(double valor) 
		{
			conta.CreditarSaldo(valor);
		}

		public void RealizarVerificaoSaldo()
		{
			conta.VerificarSaldo();
		}

		public void RealizarEncerramento()
		{
			conta.EncerrarConta();
		}

		protected abstract IContaPadrao CriarConta();
	}
}
