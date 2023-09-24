using AbstractFactory.JogoRpg.Enemies.Interface;

namespace AbstractFactory.JogoRpg.Enemies.Alianca
{
    internal class Ladino : IEnemie
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o herói mais proximo com suas duas lâminas!");
        }

        public void Defend()
        {
            Console.WriteLine("Defenda-se com seu manto invisível!");
        }
    }
}
