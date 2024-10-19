using Bridge.Platforms;

namespace Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform) : base(platform) { }

        public void Subtitle() 
        {
            Console.WriteLine("Legendas ativadas na trasmissão!");
        }

        public void Comments() 
        {
            Console.WriteLine("Comentarios liberados na live!");
        }

        public void Record()
        {
            Console.WriteLine("Gravando live!");
        }
    }
}
