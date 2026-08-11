public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date,length)
    {
        _date = date;
        _length = length;
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} minutes) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km.";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
}