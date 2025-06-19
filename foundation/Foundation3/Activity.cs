public abstract class Activity
{
    protected float _distance;
    protected float _speed;
    protected float _pace;
    protected float _time;

    public string GetSummary()
    {
        return ($"{DateTime.Today} {GetType().Name} ({_time} min) {GetDistance()} kilometers, Speed {_speed} km/h Pace{_pace} min/km");
    }
    public abstract float GetDistance();

}