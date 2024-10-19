namespace FactoryMethod.Pagamentos.Classes
{
    public abstract class PagamentoProduct
    {
        protected double _taxa { set; get; }

        protected string _tipo { set; get; }

        public abstract void Pagar(double valor);
    }
}
