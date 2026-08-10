public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckbox()} {_shortName} ({_description})";
    }

    public string GetCheckbox()
    {
        if (_isComplete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description}, {_points},{_isComplete}";
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override int GetPoints()
    {
        return _points;
    }
}