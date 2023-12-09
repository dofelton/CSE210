// Inherit from Event class, class specific: weather

class Outdoor : Event
{
    private string _type = "an Outdoor";
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string city, string state, string country, string weather) : base(title, description, date, time, address, city, state, country)
    {
        _weather = weather;
    }

    public string GetWeather()
        { return _weather; }
    public void DisplayFullDetails(string title, string description, string date, string time, string address, string type, string weather)
    {
        Console.WriteLine($"Full Details:\n{title}: {description}, {date}, {time}, {address}\nIt is {type} activity and the weather will be {weather}.");
    }
}


