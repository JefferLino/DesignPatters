using AbstractFactory.JogoRpg.Enemies.Interface;

namespace AbstractFactory.JogoRpg.Enemies.Horda
{
    internal class Globin : IEnemie
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o herói mais proximo com seu machado de aço valiriano!");
        }

        public void Defend()
        {
            Console.WriteLine("Defenda-se com escudo de carvalho e pele de urso!");
        }
    }
}
