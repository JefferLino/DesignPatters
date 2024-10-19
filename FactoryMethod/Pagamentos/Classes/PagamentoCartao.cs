namespace FactoryMethod.Pagamentos.Classes
{
    public class PagamentoCartao : PagamentoProduct
    {
        public override void Pagar(double valor)
        {
            _taxa = 15;
            _tipo = "Cartão";

            var valorFinal = valor + _taxa;

            Console.WriteLine($"Valor da conta CARTÃO: {valor}. Valor final: {valorFinal}.");
        }
    }
}
