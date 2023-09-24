namespace AbstractFactory.EstacoesRadio.Online
{
	internal class Gospel : IRadioOnline
	{
		public void TocarMusica()
		{
			Console.WriteLine("Tocando louvores!");
		}

		public void TocarPropaganda()
		{
			Console.WriteLine("Tocando propagandas para a comunidade cristã!");
		}
	}
}
