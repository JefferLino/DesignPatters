namespace FactoryMethod.Contas
{
	internal class Poupanca : IContaPadrao
	{
		private static double SaldoConta = 0;

		public void NovaConta()
		{
			Console.WriteLine("Conta poupança criada com sucesso!");
		}

		public void CreditarSaldo(double valor)
		{
			SaldoConta += valor;
			Console.WriteLine($"Crédito realizado com sucesso. Saldo disponível: {SaldoConta}!");
		}

		public void DebitarSaldo(double valor)
		{
			if (SaldoConta == 0 || valor > SaldoConta)
				Console.WriteLine($"Saldo insuficiente para essa operação!");
			else 
			{
				SaldoConta -= valor;
				Console.WriteLine($"Débito realizado com sucesso. Saldo disponível: {SaldoConta}!");
			}
		}

		public void EncerrarConta()
		{
			Console.WriteLine("Conta poupança encerrada com sucesso!");
		}

		public void VerificarSaldo()
		{
			Console.WriteLine($"Saldo da conta poupança: {SaldoConta}!");
		}
	}
}
