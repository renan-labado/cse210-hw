public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inAmerica;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetEverything()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public bool CheckAddress(string country)
    {
        if (country == "USA")
        {
            _inAmerica = true;
        }
        else if (country == "United States")
        {
            _inAmerica = true;
        }
        else
        {
            _inAmerica = false;
        }
        return _inAmerica;
    }

    public string GetCountry()
    {
        return _country;
    }
}