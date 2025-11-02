namespace Ex_03_11.Mosules;
/// <summary>
/// マウスを表すクラス
/// </summary>
public class Mouse : IUSB
{
    /// <summary>
    /// 繋がっている装置からデータを受け取る機能のメソッド
    /// </summary>
    public void ReciveData()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// 繋がっている装置にデータを送る機能のメソッド
    /// </summary>
    public void SendData()
    {
        Console.WriteLine("PCにマウスの移動情報を送信しました");
    }
}
