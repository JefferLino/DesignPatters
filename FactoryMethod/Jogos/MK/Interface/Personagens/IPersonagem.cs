using FactoryMethod.Jogos.MK.Classes.Golpes;
using FactoryMethod.Jogos.MK.Enumerados;

namespace FactoryMethod.Jogos.MK.Interface.Personagens
{
    public interface IPersonagem
    {
        void Escolhido();

        void RealizaGolpePadrao(LocalGolpe localGolpe, bool inimigoBloqueou);
    }
}
