namespace Ex_04_05.Modules;
public class TextFileAccessor
{
    /// <summary>
    /// 引数に指定されたファイルを開き、改行コード付きでList<T>内の文字列を書き込む
    /// </summary>
    /// <param name="fileName">ファイル名</param>
    /// <param name="datas">書き込むデータ</param>
    public void Write(string fileName, List<string> datas)
    {
        StreamWriter streamWriter = new StreamWriter(fileName);
        try
        {
            foreach (var data in datas)
            {
                streamWriter.WriteLine(data);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            streamWriter.Close();
        }
    }
    
    /// <summary>
    /// 引数に指定されたファイルを開き、１行単位で読み取ってコンソールに出力する
    /// </summary>
    /// <param name="fileName">ファイル名</param>

    public void ReadAndPrint(string fileName)
    {
        StreamReader streamReader = new StreamReader(fileName);
        try
        {
            string line = "";
            while ((line = streamReader.ReadLine()!) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally {
            streamReader.Close(); 
        }
    }
}
