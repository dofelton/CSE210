

public class Checklist : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }    
    public int GetBonus()
    {
        return _bonus;
    }
}