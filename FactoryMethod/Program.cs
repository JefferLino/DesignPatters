using FactoryMethod.Factories;

namespace FactoryMethod
{
	internal class Program
	{
		const string CONTA_CORRENTE = "--corrente";
		const string CONTA_POUPANCA = "--poupanca";
		const string CONTA_SALARIO = "--salario";

		static void Main(string[] args)
		{
			var opcao = args.Length > 0 ? args[0] : string.Empty;

			switch (opcao)
			{
				case CONTA_CORRENTE:

					var contaCorrente = new ContaCorrente();
					RealizarOperacoesDaConta(contaCorrente, 1500, 100);

					break;

				case CONTA_POUPANCA:

					var contaPoupanca = new ContaPoupanca();
					RealizarOperacoesDaConta(contaPoupanca, 200, 150);

					break;

				case CONTA_SALARIO:

					var contaSalario = new ContaSalario();
					RealizarOperacoesDaConta(contaSalario, 500, 50);

					break;

				default:
					Console.WriteLine("Selecione o tipo de conta!");
					break;
			}

			static void RealizarOperacoesDaConta(Conta conta, double valorCredito, double valorDebito)
			{
				conta.RealizarAbertura();
				conta.RealizarCredito(valorCredito);
				conta.RealizarDebito(valorDebito);
				conta.RealizarVerificaoSaldo();
				conta.RealizarEncerramento();
			}
		}
	}
}