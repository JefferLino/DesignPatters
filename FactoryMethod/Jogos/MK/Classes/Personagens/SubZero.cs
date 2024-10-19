using FactoryMethod.Jogos.MK.Classes.Golpes;
using FactoryMethod.Jogos.MK.Enumerados;
using FactoryMethod.Jogos.MK.Interface.Personagens;

namespace FactoryMethod.Jogos.MK.Classes.Personagens
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
            => Console.Write("Sub Zero");

        public void RealizaGolpePadrao(LocalGolpe localGolpe, bool inimigoBloqueou)
        {
            var golpePadrao = new GolpePadrao(25, localGolpe, inimigoBloqueou);
            golpePadrao.ExcutarGolpe();
        }
    }
}
