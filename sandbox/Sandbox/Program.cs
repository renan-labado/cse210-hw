using System;

class Program
{
    static void Main(string[] args)
    {
        Employee em1 = new Employee("Jordan Lee", "H001");
        Console.WriteLine(em1.GetEmployeeInfo());

        HourlyEmployee em2 = new HourlyEmployee("Renz", "C002", 5, 2);
        Console.WriteLine(em2.GetEmployeeInfo());
        Console.WriteLine(em2.CalculatePay());

        SalariedEmployee em3 = new SalariedEmployee("Joe Mama", "P102", 1257);
        Console.WriteLine(em3.GetEmployeeInfo());
        Console.WriteLine(em3.GetMonthlySalary());
    }
}