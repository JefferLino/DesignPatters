namespace AbstractFactory.Tranportes.Aircrafts
{
    internal class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a sudeteste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros á bordo, ligando as helices!");
        }

        public void StarRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
