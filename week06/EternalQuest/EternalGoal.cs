public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}