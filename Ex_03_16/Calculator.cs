namespace Ex_03_16;

public class Calculator
{
    public int Div(int x , int y)
    {
        if (x <= 0)
        {
            throw new InputParameterLessThanZeroException(x);
        }

        return x / y;
    }
}
