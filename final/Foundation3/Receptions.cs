// Inherit from Event class, class specific: RSVP list

class Receptions : Event
{
    private string _type = "a Reception";
    private List<string> _reservations;

    public Receptions(string title, string description, string date, string time, string address, string city, string state, string country) : base(title, description, date, time, address, city, state, country)
    {
        _reservations  = new List<string>();
    }
    
    public override void DisplayFullDetails(string title, string description, string date, string time, string address, string type)
    {
        Console.WriteLine($"Full Details:\n{title}: {description}, {date}, {time}, {address}\nIt is {type} and you can RSVP at rsvp@hotmail.com.");
    }
}