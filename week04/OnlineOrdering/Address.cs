using System;

public class Address
{
    private string street_address;
    private string city;
    private string state;
    private string country;

    public Address(string street, string prop_city, string prop_state, string prop_country)
    {
        street_address = street;
        city = prop_city;
        state = prop_state;
        country = prop_country;
    }

    public string ReturnAllDetailsInNewLine()
    {
        return $"{street_address}, {city}, {state}, {country}";
    }

    public string IfCountryInUSA()
    {
        return country;
    }
}