public class ExerciseBicycle : Activity
{
    public ExerciseBicycle(int distance, int speed, int pace)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public override float GetDistance()
    {
        return _distance;
    }
}