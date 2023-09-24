namespace AbstractFactory.EstacoesRadio.Online
{
	internal class Rock : IRadioOnline
	{
		public void TocarMusica()
		{
			Console.WriteLine("Tocando só os classícos do rock!");
		}

		public void TocarPropaganda()
		{
			Console.WriteLine("Tocando propagandas pros tiozão :D");
		}
	}
}
