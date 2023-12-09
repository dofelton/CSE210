// Inherit from Event class, class specific attributes: speaker, capacity

class Lectures : Event
{
    private string _type = "a Lecture";
    private string _speaker; 
    private int _capacity;

    public Lectures(string title, string description, string date, string time, string address, string city, string state, string country, string speaker, int capacity) : base(title, description, date, time, address, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public int GetCapacity()
    { 
        return _capacity; 
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void DisplayFullDetails(string title, string description, string date, string time, string address, string type, string speaker, int capacity)
    {
        Console.WriteLine($"Full Details:\n{title}: {description}, {date}, {time}, {address}\nIt is a {type} and {speaker} will be presenting to {capacity} people.");
    }
    
}