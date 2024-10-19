namespace FactoryMethod.Apis.Classes
{
    public abstract class ApiRetornoBase
    {
        protected string CodigoErro { get; set; }

        protected string MensagemErro { get; set; }

        protected bool ConsultaValida()
            => string.IsNullOrEmpty(CodigoErro);
    }
}
