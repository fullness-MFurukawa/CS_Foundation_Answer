namespace Ex_03_15;

public class InputParameterLessThanZeroException : Exception
{
    public InputParameterLessThanZeroException(int param)
    : base($"xに{param}が入力されました。正の値を入力してください。") { }
}
