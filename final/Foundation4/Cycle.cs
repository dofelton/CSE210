// inherit from Activity, attributes- speed
class Cycle : Activity
{
    private double _speed;
    public Cycle(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public double GetSpeed()
    { return _speed; }
    public void GetSummary(Activity activity, string date, double duration, double speed)
    {
        double distance = CalcDistance(speed, duration);
        Console.WriteLine($"{date} {activity.GetType()}- Distance: {distance} miles, Speed: {speed} mph, Pace: {CalcPace(duration, distance)}");
    }
    public void ListGetSummary(Cycle act)
    {
        Console.WriteLine($"{act.GetDate()} {act.GetType()}- Distance: {act.CalcDistance(GetSpeed(), GetDuration())} miles, Speed: {GetSpeed()} , Pace: {CalcPace(act.GetDuration(), act.CalcDistance(GetSpeed(), GetDuration()))}");
    }
}
