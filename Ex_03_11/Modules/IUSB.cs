namespace Ex_03_11.Mosules;
/// <summary>
/// USBを表すインターフェイス
/// </summary>
public interface IUSB
{
    /// <summary>
    /// 繋がっている装置にデータを送る機能の抽象メソッド
    /// </summary>
    void SendData();
    /// <summary>
    /// 繋がっている装置からデータを受け取る機能の抽象メソッド
    /// </summary>
    void ReciveData();
}
