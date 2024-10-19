namespace FactoryMethod.Pagamentos.Classes
{
    public class PagamentoBoleto : PagamentoProduct
    {
        public override void Pagar(double valor)
        {
            _taxa = 10;
            _tipo = "Boleto";

            var valorFinal = valor + _taxa;

            Console.WriteLine($"Valor da conta BOLETO: {valor}. Valor final: {valorFinal}.");
        }
    }
}
