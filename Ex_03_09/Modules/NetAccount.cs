namespace Ex_03_09.Modules;
/// <summary>
/// Accountクラスを継承した、NetAccountクラス
/// </summary>
public class NetAccount : Account
{
    public int Point { get; set; }  // ポイントを表すプロパティ

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="AccountNo">口座番号</param>
    /// <param name="AccountName">口座名義</param>
    /// <param name="Balance">残高</param>
    /// <param name="Point">ポイント</param>
    public NetAccount(string AccountNo, string AccountName, int Balance, int Point)
    : base(AccountNo, AccountName, Balance)
    {
        this.Point = Point;
    }

    /// <summary>
    /// AccountクラスのPrintメソッドを呼び出し、加えてポイントを表すプロパティも表示
    /// </summary>
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"ポイント = {Point}");
    }

    /// <summary>
    /// AccountクラスのToString()メソッドの結果とポイントを表すプロパティも含んだ文字列を返却
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"[NetAccount {base.ToString()},Point={Point}]";
    }
}
