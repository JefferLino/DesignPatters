using Builder.Jogos.MedalOfHonor.Classes;

namespace Builder.Jogos.MedalOfHonor.Fabrica
{
    public class CriadorForcasEspeciais : CriadorDeSoldado
    {
        public CriadorForcasEspeciais()
        {
            _soldado = new SoldadoDeForcasEspeciais(); 
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Fuzil");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Carro de operações especiais");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Combate em solo");
        }
    }
}
