using AbstractFactory.StarCraft.Interfaces.Base;

namespace AbstractFactory.StarCraft.Energia
{
    internal class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
