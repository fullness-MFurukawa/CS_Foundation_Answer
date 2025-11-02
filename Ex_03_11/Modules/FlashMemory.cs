using System.Collections;

namespace Ex_03_11.Mosules;
/// <summary>
/// フラッシュメモリを表すクラス
/// </summary>
public class FlashMemory : IUSB
{
    /// <summary>
    /// 繋がっている装置からデータを受け取る機能のメソッド
    /// </summary>
    public void ReciveData()
    {
        Console.WriteLine("PCのデータをフラッシュメモリに記録しました");
    }
    /// <summary>
    /// 繋がっている装置にデータを送る機能のメソッド
    /// </summary>
    public void SendData()
    {
        Console.WriteLine("フラッシュメモリに記録してあるデータをPCに送りました");
    }
}
