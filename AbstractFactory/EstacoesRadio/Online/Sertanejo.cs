namespace AbstractFactory.EstacoesRadio.Online
{
	internal class Sertanejo : IRadioOnline
	{
		public void TocarMusica()
		{
			Console.WriteLine("Tocando só modão sertanejo!");
		}

		public void TocarPropaganda()
		{
			Console.WriteLine("Tocando propagandos pra galera do campo e do sertão!");
		}
	}
}
