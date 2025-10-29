namespace Ex_03_04;
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public double salesTaxRate = 0.10; // 消費税率
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価

    public void Print()
    {
        Console.WriteLine("商品番号 = " + itemNo);
        Console.WriteLine("商品名 = " + itemName);
        Console.WriteLine("単価 = " + price);
    }

    public void ChangePrice(int pprice)
    {
        price = pprice;
    }

    public int CalculateTaxAmount()
    {
        int result = (int)(price + salesTaxRate * price);
        return result;
    }
}
