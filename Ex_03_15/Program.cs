namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("値1を入力してください->");
            int x = int.Parse(Console.ReadLine()!);
            Console.Write("値2を入力してください->");
            int y = int.Parse(Console.ReadLine()!);
            Calculator calculator = new Calculator();
            int result = calculator.Div(x, y);
            Console.WriteLine($"{x} / {y} = {result}");
        }
        catch (InputParameterLessThanZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"例外:{ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
            Console.WriteLine("プログラム正常終了");
        }
    }
}
