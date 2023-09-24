using AbstractFactory.JogoRpg.Enemies.Interface;

namespace AbstractFactory.JogoRpg.Enemies.Horda
{
    internal class Orc : IEnemie
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o herói mais proximo com sua lança!");
        }

        public void Defend()
        {
            Console.WriteLine("Defenda-se com seu escudo de madeira e ossos!");
        }
    }
}
