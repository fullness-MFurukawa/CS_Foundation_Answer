namespace Ex_03_14;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        int value1 = int.Parse(Console.ReadLine()!);
        Console.Write("値2を入力してください->");
        int value2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"加算: {value1.Add(value2)}");
        Console.WriteLine($"平均: {value1.Average(value2)}");
    }
}
