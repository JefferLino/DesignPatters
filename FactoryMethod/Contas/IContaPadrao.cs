namespace FactoryMethod.Contas
{
	internal interface IContaPadrao
	{
		void NovaConta();

		void DebitarSaldo(double valor);

		void CreditarSaldo(double valor);

		void VerificarSaldo();

		void EncerrarConta();
	}
}
