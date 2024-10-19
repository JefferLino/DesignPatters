using AbstractFactory.StarCraft.Interfaces.Base;

namespace AbstractFactory.StarCraft.Revestimento
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
