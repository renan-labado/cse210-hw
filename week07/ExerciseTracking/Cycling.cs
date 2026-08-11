public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _date = date;
        _length = length;
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length}) minutes - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
    public override double GetDistance()
    {
        return _length * _speed / 60;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}