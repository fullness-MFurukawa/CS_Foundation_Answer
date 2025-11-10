using Ex_04_05.Modules;

namespace Ex_04_05;

static class Program
{
    static void Main(string[] args)
    {
        List<string> datas = new List<string>();
        while (true)
        {
            Console.Write("書き込むデータを入力してください->");
            var data = Console.ReadLine();
            if (data == "End")
            {
                break;
            }
            datas.Add(data!);
        }
        TextFileAccessor accessor = new TextFileAccessor();
        accessor.Write("test.txt", datas);
        Console.WriteLine("ファイルにデータを書き込みました。");
        accessor.ReadAndPrint("test.txt");
        Console.WriteLine("ファイルのデータを読み取りました。");
    }
}
