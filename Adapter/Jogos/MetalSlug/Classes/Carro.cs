namespace Adapter.Jogos.MetalSlug.Classes
{
    public class Carro
    {
        public void Andar(string jogador)
        {
            Console.WriteLine(jogador + " LIGOU O CARRO!");
        }

        public void SoltarTorpedo()
        {
            Console.WriteLine("Soltou um torpedo no jogo!");
        }
    }
}
