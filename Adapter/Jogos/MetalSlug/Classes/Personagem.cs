using Adapter.Jogos.MetalSlug.Interfaces;

namespace Adapter.Jogos.MetalSlug.Classes
{
    public class Personagem : IAcao
    {
        public void Andar(string jogador)
        {
            Console.WriteLine(jogador + " ANDOU PARA FRENTE!");
        }

        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }
    }
}
