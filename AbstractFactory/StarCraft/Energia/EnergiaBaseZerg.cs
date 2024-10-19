using AbstractFactory.StarCraft.Interfaces.Base;

namespace AbstractFactory.StarCraft.Energia
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pel a terra");
        }
    }
}
