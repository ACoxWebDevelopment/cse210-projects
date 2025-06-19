public class LapSwimming : Activity
{
    private int _laps;
    public LapSwimming(int laps, float time)
    {
        _speed = (_distance/time) * 60;
        _distance = _laps * 50 / 1000;
        _pace = 60/_speed;
        _laps = laps;
    }
    public override float GetDistance()
    {
        return _distance;
    }
}