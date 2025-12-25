namespace Ex_03_14;

/// <summary>
/// int型の拡張メソッド
/// </summary>
public static class IntExtensions
{
    /// <summary>
    /// 値を加算する
    /// </summary>
    /// <param name="a">拡張されたint型</param>
    /// <param name="b">加算対象</param>
    /// <returns></returns>
    public static int Add(this int a, int b)
    {
        return a + b;
    }
    /// <summary>
    /// 平均を求めた結果を返す
    /// </summary>
    /// <param name="a">拡張されたint型</param>
    /// <param name="b">加算対象</param>
    /// <returns></returns>
    public static double Average(this int a, int b)
    {
        return (a + b) / 2;
    }
}
