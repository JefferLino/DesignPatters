using Builder.Jogos.MedalOfHonor.Classes;

namespace Builder.Jogos.MedalOfHonor.Fabrica
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadeDeInfantariaLeve();
        }

        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Transporte()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }

        public override void Foco()
        {
            _soldado.DefinirFoco("Resposta rápida aérea");
        }
    }
}
