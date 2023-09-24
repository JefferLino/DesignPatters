using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Heroes.Alianca
{
    internal class Mage : IHero
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o inimigo mais proximo com sua magia!");
        }

        public void Defend()
        {
            SelfHealing();
            Console.WriteLine("Defender utilizando seu chapéu!");
        }

        public void SelfHealing()
        {
            Console.WriteLine("Realizando recuperação da vida!");
        }
    }
}
