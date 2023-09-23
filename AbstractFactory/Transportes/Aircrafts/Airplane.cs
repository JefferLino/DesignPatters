namespace AbstractFactory.Tranportes.Aircrafts
{
    internal class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos a 30km, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros á bordo, voô autorizado!");
        }

        public void StarRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
