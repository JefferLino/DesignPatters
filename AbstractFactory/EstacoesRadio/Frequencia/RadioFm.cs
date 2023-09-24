namespace AbstractFactory.EstacoesRadio.Frequencia
{
	internal class RadioFm : IRadioPorFrequencia
	{
		public void TocarMusica()
		{
			Console.WriteLine("Tocando músicas com variedades de estilo, na frequência FM!");
		}

		public void TocarPropaganda()
		{
			Console.WriteLine("Tocando várias propagandas, na frequência FM!");
		}

		public void TocarVozDoBrasil()
		{
			Console.WriteLine("Tocando a voz do Brasil as 18:30, na frequência FM!");
		}
	}
}
