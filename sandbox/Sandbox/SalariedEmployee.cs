public class SalariedEmployee : Employee
{
    private double _monthlySalary;

    public SalariedEmployee(string name, string id, double monthlySalary) : base(name, id)
    {
        _monthlySalary = monthlySalary;
    }

    public double GetMonthlySalary()
    {
        return _monthlySalary;
    }
}