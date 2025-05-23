public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int oneParam)
    {
        _topNum = oneParam;
        _bottomNum = 1;
    }
    public Fraction(int oneParam, int twoParam)
    {
        _topNum = oneParam;
        _bottomNum = twoParam;
    }

    public void DisplayFraction()
    {
       Console.WriteLine($"{_topNum} / {_bottomNum}");
    }

    public int GetTopNum()
    {
        return _topNum;
    }

    public int GetBotNum()
    {
        return _bottomNum;
    }

    public void SetTopNum(int userTop)
    {
        _topNum = userTop;
    }

    public void SetBottomNum(int userBottom)
    {
        _bottomNum = userBottom;
    }

    public void DisplayDecimal()
    {
        Console.WriteLine((double)_topNum / _bottomNum);
    }

    

}