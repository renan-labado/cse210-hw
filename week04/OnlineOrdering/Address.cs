public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inAmerica;

    public Address(string streetAddress, string city, string state, string country)
    {
        
    }

    public string ReturnEverything()
    {
        return "";
    }

    public void CheckAddress(string country)
    {
        if (country == "USA")
        _inAmerica = true;
    }
}