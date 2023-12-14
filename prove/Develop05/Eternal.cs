public class Eternal : Goals
{
    // items that won't ever get checked off
    // call base class, override methods
    // checklist

    public Eternal(string name, string description, string points) : base(name, description, points)
    {

    }

    public virtual void RecordEvent(int index)
    {
        
    }
}