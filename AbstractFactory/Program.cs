using AbstractFactory.Factories;
using AbstractFactory.Tranportes.App;
using AbstractFactory.Tranportes.Factories;

namespace AbstractFactory
{
    internal class Program
	{
		static void Main(string[] args)
		{
			var app = ConfigureApplication("Lime");
			app.StartRoute();

			Console.ReadLine();
		}

		static Application ConfigureApplication(string companiaSelecionada)
		{
			ITransportFactory tranpostFactory = companiaSelecionada switch
			{
				"Uber" => new UberTransport(),
				"99" => new NineNineTransport(),
				"Lime" => new LimeTransport(),
				_ => new UberTransport(),
			};

			return new Application(tranpostFactory);
		}
	}
}