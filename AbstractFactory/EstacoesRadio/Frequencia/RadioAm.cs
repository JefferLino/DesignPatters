namespace AbstractFactory.EstacoesRadio.Frequencia
{
	internal class RadioAm : IRadioPorFrequencia
	{
		public void TocarMusica()
		{
			Console.WriteLine("Tocando músicas com variedades de estilo, na frequência AM!");
		}

		public void TocarPropaganda()
		{
			Console.WriteLine("Tocando várias propagandas, na frequência AM!");
		}

		public void TocarVozDoBrasil()
		{
			Console.WriteLine("Tocando a voz do Brasil as 18:30, na frequência AM!");
		}
	}
}
