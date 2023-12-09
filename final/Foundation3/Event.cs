// base class; title: string, description: string, date: datetime? or string?, time: datetime? or string?, address: class
// methods DisplayStandardDetails, DisplayFullDetails, ShortDescription

class Event
{
    // make attributes private
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    private string _type;

    public Event(string title, string description, string date, string time, string address, string city, string state, string country)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        Address a1 = new Address(address, city, state, country);
        _address = a1.GetAddress();
    }
    public string GetTitle()
    { return _title; }
    public string GetDescription()
    { return _description; }
    public string GetDate()
    { return _date; }
    public string GetTime()
    { return _time; }
    public string GetAddress()
    { return _address; }
    public string GetType()
    { return _type; }
    public void DisplayShort(string type, string title, string date)
    {
        Console.WriteLine($"Short details:\nThis is a {type} event called {title} held on {date}.");
    }
    public void DisplayStandardDetails(string title, string description, string date, string time, string address)
    {
        Console.WriteLine($"Standard details:\n{title}: {description}, {date}, {time}, {address}");
    }
    
    public virtual void DisplayFullDetails(string title, string description, string date, string time, string address, string type)
    {
        Console.WriteLine($"{title}: {description}, {date}, {time}, {address}\nIt is a {type}");
    }

    
}