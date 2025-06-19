public class LapSwimming : Activity
{
    private int _laps;
    public LapSwimming(int laps, int speed, int pace)
    {
        _speed = speed;
        _pace = pace;
        _laps = laps;
    }
    public override float GetDistance()
    {
        return _distance = _laps * 50/1000;
    }
}