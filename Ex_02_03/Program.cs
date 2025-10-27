namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        int value = int.Parse(Console.ReadLine());
        int value1 = value + 5;
        int value2 = value - 5;
        Console.WriteLine("5を加算した結果は" + value1+"です。");
        Console.WriteLine("5を減算した結果は" + value2+"です。");
    }
}
