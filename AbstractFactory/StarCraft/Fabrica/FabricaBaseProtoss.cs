using AbstractFactory.StarCraft.Energia;
using AbstractFactory.StarCraft.Interfaces.Fabrica;
using AbstractFactory.StarCraft.Revestimento;

namespace AbstractFactory.StarCraft.Fabrica
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!");

            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            RevestimentoBaseProtoss energia = new RevestimentoBaseProtoss();
            energia.Composicao();
        }
    }
}
