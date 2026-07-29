public class HourlyEmployee : Employee
{
    private double _hourlyRate;
    private double _hoursWorked;

    public HourlyEmployee(string name, string id, double rate, double hours) : base(name, id)
    {
        _hourlyRate = rate;
        _hoursWorked = hours;
    }

    public double CalculatePay()
    {
        double pay = _hourlyRate * _hoursWorked;
        return pay;
    }
}