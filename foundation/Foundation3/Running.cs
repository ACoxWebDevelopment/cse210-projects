public class Running : Activity
{
    public Running(float distance, float time)
    {
        _distance = distance;
        _speed = (distance / time) * 60;
        _pace = time/distance;
        _time = time;
    }

    public override float GetDistance()
    {
        return _distance;
    }
}