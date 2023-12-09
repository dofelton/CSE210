// base class; title: string, description: string, date: datetime? or string?, time: datetime? or string?, address: class
// methods DisplayStandardDetails, DisplayFullDetails, ShortDescription

class Event
{
    // make attributes private
<<<<<<< HEAD
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address
    }

    public void DisplayStandardDetails(string title, string description, string date, string time, string address)
    {
        Console.WriteLine($"{title}: {description}, {date}, {time}, {address}")
    }
    
=======
>>>>>>> 06c361c4c2ad45bd5aa275e32cb88e4d15f9a571
}