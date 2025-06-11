class Shape
{
    protected string _color;

    public string GetColor()
    {
        return ($"{_color}");
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    virtual public double GetArea()
    {
        return 0.123;
    }
}