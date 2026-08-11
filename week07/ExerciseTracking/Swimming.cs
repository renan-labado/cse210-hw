public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _date = date;
        _length = length;
        _laps = laps;
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length}) minutes - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km, with {_laps} laps";
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length;
    }
}