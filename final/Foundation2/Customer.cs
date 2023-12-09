// name: string and address: class, method to determine domestic or not(call method on the address)

class Customer
{
    private string _name;
    private string _address;
    private bool _isDomestic;

    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        Address a1 = new Address(address, city, state, country);
        _address = a1.GetAddress();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    { 
        return _address;
    }

    private bool isDomestic(string _address)
    {
        List<string> splitAddress = new List<string>(_address.Split(","));
        return _isDomestic = splitAddress[3] == "US";
    }
}