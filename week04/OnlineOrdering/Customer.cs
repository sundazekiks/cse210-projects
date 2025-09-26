using System;

public class Customer
{
    private string name;
    private Address address;

    public void CustomerDetails(string _name, string prop_address, string prop_city, string prop_state, string prop_country)
    {
        name = _name;
        address = new Address(prop_address, prop_city, prop_state, prop_country);

    }

    public string getCustomerName()
    {
        return name;
    }

    public bool checkIfCustomerIsInUS()
    {
        if (address.IfCountryInUSA().ToLower() == "usa")
        {
            return true;
        }

        return false;
    }

    public string PassAddressToOrder()
    {
        return address.ReturnAllDetailsInNewLine();
    }



}