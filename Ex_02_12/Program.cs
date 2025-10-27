namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");
        int value = int.Parse(Console.ReadLine());
        int result = Mul3(value);
        Console.WriteLine(result);
    }

    static int Mul3(int value)
    {
        return value * 3;
    }
}
