namespace Builder.Jogos.MedalOfHonor.Classes
{
    public class SoldadoDeForcasEspeciais : Soldado
    {
        public override void EscolherArma(string arma)
        {
            Arma = arma;
        }

        public override void EscolherTransporte(string transporte)
        {
            Transporte = transporte;
        }

        public override void DefinirFoco(string foco)
        {
            Foco = foco;
        }
    }
}