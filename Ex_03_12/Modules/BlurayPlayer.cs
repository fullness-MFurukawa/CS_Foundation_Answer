namespace Ex_03_12.Mosules;
/// <summary>
/// Blu-rayプレーヤーを表すクラス
/// </summary>
public class BlurayPlayer : Player
{
    public BlurayPlayer(string Media) : base(Media)
    {
        
    }

    /// <summary>
    /// メディアを再生中であることを出力する
    /// </summary>
    public override void Play()
    {
        Console.WriteLine($"Blu-ray:{Media}を再生しています");
    }

    /// <summary>
    /// メディアの再生を停止したことを出力する
    /// </summary>
    public override void Stop()
    {
        Console.WriteLine($"Blu-ray:{Media}の再生を停止しました");
    }
}
