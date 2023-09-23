namespace AbstractFactory.Tranportes.Landvehicles
{
    internal class Patinete : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda com nosso patinete!");
        }

        public void StarRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega como nosso patinete!");
        }
    }
}
