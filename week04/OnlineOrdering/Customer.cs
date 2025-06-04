using System.Net.Sockets;

class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public string GetName()
    {
        return _name;
    }    
}