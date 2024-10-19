namespace FactoryMethod.Pagamentos.Classes
{
    public class PagamentoPix : PagamentoProduct
    {
        public override void Pagar(double valor)
        {
            _taxa = 0;
            _tipo = "Pix";

            var valorFinal = valor + _taxa;

            Console.WriteLine($"Valor da conta PIX: {valor}. Valor final: {valorFinal}.");
        }
    }
}
