public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address (string street, string city, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = "(Small country no big provinces)";
        _country = country;
    }

    public Address (string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateProvince;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states of america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}