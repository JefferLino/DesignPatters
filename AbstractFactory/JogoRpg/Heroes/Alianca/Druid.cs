using AbstractFactory.JogoRpg.Heroes.Interface;

namespace AbstractFactory.JogoRpg.Heroes.Alianca
{
    internal class Druid : IHero
    {
        public void Attack()
        {
            Console.WriteLine("Atacar o inimigo mais proximo com seu arco de druida!");
        }

        public void Defend()
        {
            SelfHealing();
            Console.WriteLine("Defender utilizando seu escudo de druida!");
        }

        public void SelfHealing()
        {
            Console.WriteLine("Realizando recuperação da vida!");
        }
    }
}
