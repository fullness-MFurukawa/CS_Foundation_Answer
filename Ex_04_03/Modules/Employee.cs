namespace Ex_04_03.Modules;
/// <summary>
/// 従業員を表すクラス
/// </summary> 
public class Employee
{
    // 社員番号を表すプロパティ
    public int Id { get; set; }
    // 名前を表すプロパティ
    public string? Name { get; set; }
    // 住所を表すプロパティ
    public string? Address { get; set; }
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="id">社員番号</param>
    /// <param name="name">名前</param>
    /// <param name="address">住所</param>
    public Employee(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }

    public override string ToString()
    {
        return $"Employee[ id={Id} , name={Name} , address={Address}]";
    }
}
