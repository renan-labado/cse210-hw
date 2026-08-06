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
}