using FactoryMethod.Jogos.MK.Classes.Golpes;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.Interface.Personagens;

namespace FactoryMethod.Jogos.MK.Classes.Personagens
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.Write("Liu Kang");
        }

        public void RealizaGolpePadrao(LocalGolpe localGolpe, bool inimigoBloqueou)
        {
            var golpePadrao = new GolpePadrao(35, localGolpe, inimigoBloqueou);
            golpePadrao.ExcutarGolpe();
        }
    }
}
