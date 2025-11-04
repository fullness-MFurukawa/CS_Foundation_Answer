namespace Ex_03_13;

/// <summary>
/// 円を表すクラス
/// </summary>
public class Circle
{
    // 円周率
    public static double PI = 3.14;
    //  半径
    int radius;

    /// <summary>
    /// フィールドの半径の値の円の面積を計算する動的メソッド
    /// </summary>
    /// <returns></returns>
    public double AreaCalculation()
    {
        return radius * radius * PI;
    }

    /// <summary>
    /// 引数の半径の値の円の面積を計算する静的メソッド
    /// </summary>
    /// <param name="radius">半径</param>
    /// <returns></returns>
    public static double AreaCalculation(int radius)
    {
        return radius * radius * PI;
    }
    
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pradius">半径</param>
    public Circle(int pradius)
    {
        radius = pradius;
    }
}
