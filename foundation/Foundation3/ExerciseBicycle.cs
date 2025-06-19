public class ExerciseBicycle : Activity
{
    public ExerciseBicycle( float speed, float time)
    {
        _distance = speed * time;
        _speed = speed;
        _pace = time/_distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }
}