public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top=1;
        _bottom=1;
    }

    public Fraction( int numerator)
    {
        _top=numerator;     
        _bottom=1;
    }
    
    
    public Fraction (int numerator, int denominator)
    {
        _top=numerator;
        _bottom=denominator;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int numerator)
    {
        _top=numerator;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int denominator)
    {
        _bottom=denominator;
    }

    public string GetFractionString()
    {
        string stringTop=_top.ToString();
        string stringBottom=_bottom.ToString();
        return ($"{stringTop}/{stringBottom}");
    }

    public double GetDecimalValue()
    {
        return Convert.ToDouble(_top)/_bottom;
    }

}