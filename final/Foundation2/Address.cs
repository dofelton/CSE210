// street address: string, city: string, state/province: string, country: string
// method to determine if domestic, DisplayAddress(with \n characters where appropriate)

class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
    public void DisplayAddress(string address, string city, string state, string country)
    {
        Console.WriteLine($"{address}\n{city}, {state}, {country}");
    }

    public bool isDomestic(string country)
    {
        if (country == "US")
        {
            return true;
        }
        else
            return false;
    }
}