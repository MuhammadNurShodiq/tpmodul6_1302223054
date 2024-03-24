using tpmodul6_1302223054;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("“Tutorial Design By Contract – [Muhammad_Nur_Shodiq]");
        video.PrintVideoDetails();

        for (int i = 1; i <= 216; i++)
        {
            video.IncreasePlayCount(10000000);
        }
        video.PrintVideoDetails();
        Console.WriteLine("Hello, World!");
    }
}