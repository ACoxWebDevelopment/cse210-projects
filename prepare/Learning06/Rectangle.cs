class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(double length, double width, string color)
    {
        _length = length;
        _width = width;
        SetColor(color);

    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
