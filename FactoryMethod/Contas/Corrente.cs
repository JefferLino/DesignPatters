namespace FactoryMethod.Contas
{
	internal class Corrente : IContaPadrao
	{
		private static double SaldoConta = 0;

		public void NovaConta()
		{
			Console.WriteLine("Conta corrente criada com sucesso!");
		}

		public void CreditarSaldo(double valor)
		{
			SaldoConta += valor;
			Console.WriteLine($"Crédito realizado com sucesso. Saldo disponível: {SaldoConta}!");
		}

		public void DebitarSaldo(double valor)
		{
			SaldoConta -= valor;
			Console.WriteLine($"Débito realizado com sucesso. Saldo disponível: {SaldoConta}!");
		}

		public void EncerrarConta()
		{
			Console.WriteLine("Conta corrente encerrada com sucesso!");
		}

		public void VerificarSaldo()
		{
			Console.WriteLine($"Saldo da conta corrente: {SaldoConta}!");
		}
	}
}
