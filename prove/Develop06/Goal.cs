using System.Dynamic;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    protected bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void SetIsComplete()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetGoal()
    {
        return ($"{_shortName} ({_description})");
    }
    public string GetStringRepresentation()
    {
        return "";
    }

    public int GetPoints()
    {
        return _points;
    }



}