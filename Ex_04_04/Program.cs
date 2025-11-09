using System.Collections.Generic;
using Ex_04_04.Modules;
namespace Ex_04_04;

static class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Item> items = new Dictionary<int, Item>();
        Item item = new Item(101, "水性ボールペン(黒)", 150);
        items.Add(101, item);
        item = new Item(102, "油性ボールペン(黒)", 100);
        items.Add(102, item);
        item = new Item(103, "鉛筆(黒)", 60);
        items.Add(103, item);
        item = new Item(104, "鉛筆(赤)", 80);
        items.Add(104, item);

        Console.Write("商品番号を入力してください->");
        int id = int.Parse(Console.ReadLine()!);
        if (items.ContainsKey(id))
        {
            Console.WriteLine(items[id]);
        }
        else
        {
            Console.WriteLine("該当する商品がありません。");
        }
    }
}
