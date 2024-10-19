using FactoryMethod.Jogos.MK.Classes.Golpes;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.Interface.Personagens;

namespace FactoryMethod.Jogos.MK.Classes.Personagens
{
    public class KungLao : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Kung Lao");
        }

        public void RealizaGolpePadrao(LocalGolpe localGolpe, bool inimigoBloqueou)
        {
            var golpePadrao = new GolpePadrao(20, localGolpe, inimigoBloqueou);
            golpePadrao.ExcutarGolpe();
        }
    }
}
