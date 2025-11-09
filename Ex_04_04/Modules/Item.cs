namespace Ex_04_04.Modules;
/// <summary>
/// 商品を表すクラス
/// </summary>
public class Item
{
    // 商品番号を表すプロパティ
    public int Id { get; set; }
    // 商品名を表すプロパティ
    public string? Name { get; set; }
    // 単価を表すプロパティ
    public int Price { get; set; }
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id">商品番号</param>
    /// <param name="name">商品名</param>
    /// <param name="price">単価</param>
    public Item(int id, string name, int price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Item[Id={Id} , Name={Name} , Price={Price}]";
    }
}
