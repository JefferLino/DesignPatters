using AbstractFactory.StarCraft.Energia;
using AbstractFactory.StarCraft.Interfaces.Fabrica;
using AbstractFactory.StarCraft.Revestimento;

namespace AbstractFactory.StarCraft.Fabrica
{
    internal class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
