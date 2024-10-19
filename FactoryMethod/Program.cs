using FactoryMethod.Factories;
using FactoryMethod.Jogos.MK.Classes.Personagens;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.FactoryMethod;
using FactoryMethod.Pagamentos.Enumerados;
using FactoryMethod.Pagamentos.FactoryMethod;

namespace FactoryMethod
{
	internal class Program
	{
		const string CONTA_CORRENTE = "--corrente";
		const string CONTA_POUPANCA = "--poupanca";
		const string CONTA_SALARIO = "--salario";

		static void Main(string[] args)
		{
			//var fmMk = new FabricaPersonagem();
			//var personagem = fmMk.EscolherPersonagem(PersonagemSelecionado.LIU_KANG);

			//personagem.Escolhido();
			//personagem.RealizaGolpePadrao(LocalGolpe.CABECA, true);

			var fmPagamento = new PagamentoFactory();

			var pagamentoBoleto = fmPagamento.PagamentoProduct(TipoPagamento.BOLETO);
			var pagamentoPix = fmPagamento.PagamentoProduct(TipoPagamento.PIX);
			var pagamentoCartao = fmPagamento.PagamentoProduct(TipoPagamento.CARTAO);

			pagamentoBoleto.Pagar(100);
            pagamentoPix.Pagar(100);
            pagamentoCartao.Pagar(100);

            var pagamentoBoleto2 = fmPagamento.PagamentoProduct(TipoPagamento.BOLETO);
            var pagamentoPix2 = fmPagamento.PagamentoProduct(TipoPagamento.PIX);
            var pagamentoCartao2 = fmPagamento.PagamentoProduct(TipoPagamento.CARTAO);

            pagamentoBoleto2.Pagar(200);
            pagamentoPix2.Pagar(200);
            pagamentoCartao2.Pagar(200);
        }
    }
}