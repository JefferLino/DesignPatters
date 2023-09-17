namespace FactoryMethod.Contas
{
	internal class Salario : IContaPadrao
	{
		private static double SaldoConta = 0;

		public void NovaConta()
		{
			Console.WriteLine("Conta salário criada com sucesso!");
		}

		public void CreditarSaldo(double valor)
		{
			if (VerficarSeCreditoEstaHabilitadoParaEstaConta())
			{
				SaldoConta += valor;
				Console.WriteLine($"Crédito realizado com sucesso. Saldo disponível: {SaldoConta}!");
			}
			else
				Console.WriteLine($"Não foi póssível realizar o crédito da conta. Não esta dentro do período permitido!");
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
			Console.WriteLine("Conta salário encerrada com sucesso!");
		}

		public void VerificarSaldo()
		{
			Console.WriteLine($"Saldo da conta salário: {SaldoConta}!");
		}

		private bool VerficarSeCreditoEstaHabilitadoParaEstaConta()
		{
			if (DateTime.Today.Day > 20 && DateTime.Today.Day < 30)
				return true;
			else
				return false;
		}
	}
}
