using Flyweight.Jogos.Classes;
using Flyweight.Jogos.PadraoFlyweight;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flyweight = new FlyweightPadrao();
            string cor = string.Empty;
            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();

                tartaruga = flyweight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("------------------------");
            }
        }
    }
}
