namespace Ex_03_09.Modules;

/// <summary>
/// 口座を表すクラス
/// </summary> 
public class Account
{
    public string? AccountNo { get; set; }   // 口座番号を表すプロパティ
    public string? AccountName { get; set; } // 口座名義を表すプロパティ
    public int Balance { get; set; }    // 残高を表すプロパティ

    /// <summary>
    /// コンストラクタ(各プロパティを初期化)
    /// </summary>
    /// <param name="AccountNo">口座番号</param>
    /// <param name="AccountName">口座名義</param>
    /// <param name="Balance">残高</param>
    public Account(string AccountNo, string AccountName, int Balance)
    {
        this.AccountNo = AccountNo;
        this.AccountName = AccountName;
        this.Balance = Balance;
    }

    /// <summary>
    /// プロパティの値を表示するメソッド
    /// </summary>
    public virtual void Print()
    {
        Console.WriteLine($"口座番号 = {AccountNo}");
        Console.WriteLine($"口座名義 = {AccountName}");
        Console.WriteLine($"残高 = {Balance}");
    }

    /// <summary>
    /// objectクラスのToString()メソッドをオーバーライドし、プロパティの値の文字列を返却するメソッド
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
    }
}