namespace Ex_03_05;
/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public double salesTaxRate = 0.10; // 消費税率
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pitemNo">商品番号</param>
    /// <param name="pitemName">商品名</param>
    /// <param name="pprice">単価</param>
    public Item(int pitemNo,string pitemName,int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }

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
