using Adapter.Jogos.MetalSlug.Interfaces;

namespace Adapter.Jogos.MetalSlug.Classes
{
    public class AdaptadorAviao : IAcao
    {
        Aviao aviao;

        public AdaptadorAviao(Aviao novo_aviao)
        {
            aviao = novo_aviao;
        }

        public void Andar(string jogador)
        {
            this.aviao.Voar(jogador);
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
