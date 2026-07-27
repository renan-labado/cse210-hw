public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool GetBoolAddress()
    {
        string country = _address.GetCountry();
        return _address.CheckAddress(country);
    }

    public string GetNameAndAddress()
    {
        return $"Name: {_name} | Address: {_address.GetEverything()}";
    }
}