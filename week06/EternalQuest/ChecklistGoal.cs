public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public string GetCheckbox()
    {
        if (_amountCompleted == _target)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public override string GetDetailsString()
    {
        return $"{GetCheckbox()} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override int GetPoints()
    {
        return _points;
    }
}