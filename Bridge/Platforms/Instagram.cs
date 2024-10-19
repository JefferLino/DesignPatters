namespace Bridge.Platforms
{
    public class Instagram : IPlatform
    {
        public Instagram()
        {
            ConfigureRMTP();
            Console.WriteLine("Instagram: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Instagram: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Instagram: Configurnasdo servidor RMTP.");
        }
    }
}
