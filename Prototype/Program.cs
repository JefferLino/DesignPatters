using Prototype.Carros;
using Prototype.Jogos.SMW.Classes;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gerenciadoDeNuves = new GerenciadorNuvens();

            gerenciadoDeNuves["padrao"] = new NuvemConcreta("branco", "azul");
            gerenciadoDeNuves["personalizada"] = new NuvemConcreta("branco", "laranja");

            var um = (NuvemConcreta)gerenciadoDeNuves["padrao"].Clone();
            var dois = (NuvemConcreta)gerenciadoDeNuves["padrao"].Clone();
            var tres = (NuvemConcreta)gerenciadoDeNuves["personalizada"].Clone();

            var carro = new Carro() { Modelo = "Honda Civic", Ano = 2016, Cor = "Cinza" };
            
            var carro1 = (Carro)carro.Clone();
            carro1.Cor = "Verde";

            var carro2 = (Carro)carro.Clone();
            carro2.Ano = 2023;

            Console.WriteLine($"Carro 1: {carro1.Modelo}, {carro1.Cor}, {carro1.Ano}");
            Console.WriteLine($"Carro 2: {carro2.Modelo}, {carro2.Cor} , {carro2.Ano}");

            Console.ReadKey();
        }
    }
}
