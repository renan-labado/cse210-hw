public class Employee
{
    private string _employeeName;
    private string _id;

    public Employee(string name, string id)
    {
        _employeeName = name;
        _id = id;
    }

    public string GetEmployeeInfo()
    {
        return $"Name: {_employeeName}\nID: {_id}";
    }

}