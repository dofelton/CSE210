public class Goals
{
    // choose type of goal
    // user input- type of goal, points checklist items
    // output- list of goals, point calculation, rewards we set up, saved data

    // abstract base class, contain base private or protected variables, abstract methods
    private string _shortName;
    private string _description;
    private string _points;

    public Goals(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    { return _shortName; }
    public string GetDescription()
    { return _description; }
    public string GetPoints()
    { return _points; }
    public void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return $"{GetName()}: {GetDescription()} Points: {GetPoints()}";
    }

    public string GetStringRepresentation()
    {
        return $"{GetName()}: {GetDescription()} Points: {GetPoints()}";
    }
}