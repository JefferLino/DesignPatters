using FactoryMethod.Jogos.MK.Classes.Golpes;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.Interface.Personagens;

namespace FactoryMethod.Jogos.MK.Classes.Personagens
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Scorpion");
        }

        public void RealizaGolpePadrao(LocalGolpe localGolpe, bool inimigoBloqueou)
        {
            var golpePadrao = new GolpePadrao(30, localGolpe, inimigoBloqueou);
            golpePadrao.ExcutarGolpe();
        }
    }
}
