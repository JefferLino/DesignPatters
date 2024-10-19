using Adapter.Jogos.MetalSlug.Interfaces;

namespace Adapter.Jogos.MetalSlug.Classes
{
    internal class AdaptadorCarro : IAcao
    {
        Carro carro;

        public AdaptadorCarro(Carro novo_carro)
        {
            carro = novo_carro;     
        }

        public void Andar(string jogador)
        {
            this.carro.Andar(jogador);
        }

        public void Atirar()
        {
            this.carro.SoltarTorpedo();
        }
    }
}
