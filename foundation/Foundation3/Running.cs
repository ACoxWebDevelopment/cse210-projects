public class Running : Activity
{
    public Running(int distance, int speed, int pace, int time)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
        _time = time;
    }

    public override float GetDistance()
    {
        return _distance;
    }
}