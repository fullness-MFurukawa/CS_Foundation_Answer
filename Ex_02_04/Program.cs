namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        var values = new int[3];
        Console.Write("数値1を入力してください->");
        values[0] = int.Parse(Console.ReadLine());
        Console.Write("数値2を入力してください->");
        values[1] = int.Parse(Console.ReadLine());
        Console.Write("数値3を入力してください->");
        values[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("数値1:" + values[0]);
        Console.WriteLine("数値2:" + values[1]);
        Console.WriteLine("数値3:" + values[2]);
    }
}
