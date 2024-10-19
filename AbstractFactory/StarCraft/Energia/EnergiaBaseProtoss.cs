using AbstractFactory.StarCraft.Interfaces.Base;

namespace AbstractFactory.StarCraft.Energia
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base com cristais");
        }
    }
}
