namespace Bridge.Platforms
{
    internal class YouTube : IPlatform
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurnasdo servidor RMTP.");
        }
    }
}
