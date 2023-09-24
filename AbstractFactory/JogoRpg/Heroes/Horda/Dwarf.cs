using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Heroes.Horda
{
    internal class Dwarf : IHero
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o inimigo mais proximo com seu martelo!");
        }

        public void Defend()
        {
            SelfHealing();
            Console.WriteLine("Defender utilizando seu escudo de anão!");
        }

        public void SelfHealing()
        {
            Console.WriteLine("Realizando recuperação da vida!");
        }
    }
}
