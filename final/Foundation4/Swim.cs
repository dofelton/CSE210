// inherit from activity, attribute- # laps
class Swim : Activity
{
    private int _laps;
    public Swim(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public int GetLaps()
    { return _laps; }
    public double CalcDistance(double laps)
    {
        return (laps * 50 / 1000 * 0.62);
    }
    public void GetSummary(Activity activity, string date, double duration, double laps)
    {
        double distance = CalcDistance(laps);
        double speed = CalcSpeed(distance, duration);
        Console.WriteLine($"{date} {activity.GetType()}- Distance: {distance} miles, Speed: {speed} mph, Pace: {CalcPace(duration, distance)}");
    }
    public void ListGetSummary(Swim act)
    {
        Console.WriteLine($"{act.GetDate()} {act.GetType()}- Distance: {act.CalcDistance(GetLaps())} miles, Speed: {CalcSpeed(act.CalcDistance(GetLaps()), act.GetDuration())} , Pace: {CalcPace(act.GetDuration(), act.CalcDistance(GetLaps()))}");
    }
}