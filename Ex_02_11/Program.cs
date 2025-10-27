namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string[] stations = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };

        Console.Write("駅名を入力してください->");
        string station = Console.ReadLine();

        for (int i = 0; i < stations.Length; i++)
        {
            if (station == stations[i])
            {
                continue;
            }
            Console.WriteLine(stations[i]);
        }
    }
}
