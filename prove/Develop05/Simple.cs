public class Simple : Goals
{
    // small, single event goals

    // call base class, private variables, override methods

    private bool _isComplete;

    public Simple(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    public virtual void RecordEvent()
    {
        
    }
}
