namespace Ex_03_10.Mosules;

/// <summary>
/// DVDプレーヤーを表すクラス
/// </summary>
public class DVDPlayer : Player
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="Media">再生メディア</param>
    /// <returns></returns>
    public DVDPlayer(string Media) : base(Media)
    {
    }

    /// <summary>
    /// メディアを再生中であることを出力する
    /// </summary>
    public override void Play()
    {
        Console.WriteLine($"DVD:{Media}を再生しています");
    }
    /// <summary>
    /// メディアの再生を停止したことを出力する
    /// </summary>
    public override void Stop()
    {
        Console.WriteLine($"DVD:{Media}の再生を停止しました");
    }
}
