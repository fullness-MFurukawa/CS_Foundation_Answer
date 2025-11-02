using Ex_03_10.Mosules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        Player dvd = new DVDPlayer(Console.ReadLine()!);
        dvd.Play();
        dvd.Stop();
        Console.Write("Blu-rayのタイトルを入力してください->");
        Player bluray = new BlurayPlayer(Console.ReadLine()!);
        bluray.Play();
        bluray.Stop();
    }
}
