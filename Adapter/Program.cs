using Adapter.Jogos.MetalSlug.Classes;
using Adapter.Jogos.MetalSlug.Interfaces;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jefferson = new Personagem();
            var aviao_de_batalha = new Aviao();
            var carro_de_batalha = new Carro();

            IAcao adptadorAviao = new AdaptadorAviao(aviao_de_batalha);
            IAcao adptadorCarro = new AdaptadorCarro(carro_de_batalha);

            Console.WriteLine("--- CAMINHANDO ---");
            jefferson.Andar("Jeff");
            jefferson.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");

            adptadorAviao.Andar("Jeff");
            adptadorAviao.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM CARRO NO JOGO ---");

            adptadorCarro.Andar("Jeff");
            adptadorCarro.Atirar();

            Console.ReadKey();
        }
    }
}