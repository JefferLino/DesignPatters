using Bridge.Platforms;
using Bridge.Transmissions;

internal class Program
{
    static void StartLive(IPlatform platform) 
    {
        Console.WriteLine("Aguarde...");

        var live = new Live(platform);

        live.Broadcasting();
        live.Result();
    }

    static void StartLiveAdvanced(IPlatform platform)
    {
        Console.WriteLine("Aguarde...");

        var live = new AdvancedLive(platform);

        live.Broadcasting();
        live.Subtitle();
        live.Comments();
        live.Record();
        live.Result();
    }

    static void Main(string[] args)
    {
        StartLiveAdvanced(new YouTube());
        StartLive(new Facebook());
        StartLive(new TwitchTV());
        StartLiveAdvanced(new Instagram());

        Console.ReadLine();
    }
}
