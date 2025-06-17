public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override string  GetGoal()
    {
        return ($"{_shortName} ({_description}) {_amountCompleted}/{_target}");
    }
}