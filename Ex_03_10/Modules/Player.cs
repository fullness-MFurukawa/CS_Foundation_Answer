namespace Ex_03_10.Mosules;

/// <summary>
/// プレーヤーを表す抽象クラス
/// </summary>
public abstract class Player
{
    public string? Media { get; set; } // 再生するメディアを表す自動プロパティ

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="Media">再生するメディア</param>
    public Player(string Media)
    {
        this.Media = Media;
    }

    /// <summary>
    /// メディアを再生中であることを出力する
    /// </summary>
    public abstract void Play();
    /// <summary>
    /// メディアの再生を停止したことを出力する
    /// </summary>
    public abstract void Stop();
}
