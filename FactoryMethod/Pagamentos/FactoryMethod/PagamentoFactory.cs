using FactoryMethod.Pagamentos.Classes;
using FactoryMethod.Pagamentos.Enumerados;

namespace FactoryMethod.Pagamentos.FactoryMethod
{
    public class PagamentoFactory
    {
        private readonly Dictionary<TipoPagamento, PagamentoProduct> pagamentos = new();

        public PagamentoProduct PagamentoProduct(TipoPagamento tipoPagamento)
        {
            if (!pagamentos.ContainsKey(tipoPagamento))
                ConfigurarDicionarioDePagamentos(tipoPagamento);

            return pagamentos[tipoPagamento];
        }

        private void ConfigurarDicionarioDePagamentos(TipoPagamento tipoPagamento)
        {
            PagamentoProduct pagamentoProduct = tipoPagamento switch
            {
                TipoPagamento.PIX => new PagamentoPix(),
                TipoPagamento.BOLETO => new PagamentoBoleto(),
                TipoPagamento.CARTAO => new PagamentoCartao(),
                _ => new PagamentoPix(),
            };

            pagamentos.Add(tipoPagamento, pagamentoProduct);
        }
    }
}
