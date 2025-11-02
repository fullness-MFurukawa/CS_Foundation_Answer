namespace Ex_03_11.Mosules;
/// <summary>
/// ディスプレイを表すクラス
/// </summary>
public class Display : IUSB
{
    /// <summary>
    /// 繋がっている装置からデータを受け取る機能のメソッド
    /// </summary>
    public void ReciveData()
    {
        Console.WriteLine("ディスプレイに表示する情報を受信しました");
    }

    /// <summary>
    /// 繋がっている装置にデータを送る機能のメソッド
    /// </summary>
    public void SendData()
    {
        throw new NotImplementedException();
    }
}
