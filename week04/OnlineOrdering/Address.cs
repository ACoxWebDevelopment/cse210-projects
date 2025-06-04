class Address
{
    string _street;
    string _city;
    string _state;
    string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }

    public Boolean IsUsa()
    {
        if (_country == "USA")
            return true;
        else return false;
    }

    public string GetAddress()
    {
        return ($"{_street} {_city} {_state}, {_country}");
    }


}