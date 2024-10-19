namespace Builder.Jogos.MedalOfHonor.Fabrica
{
    public class Exercito
    {
        public void ConstruirSoldado(CriadorDeSoldado criadorDeSoldado) 
        {
            criadorDeSoldado.Arma();
            criadorDeSoldado.Transporte();
            criadorDeSoldado.Foco();
        }
    }
}
