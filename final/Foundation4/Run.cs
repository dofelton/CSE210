// Inherite from Activity, attributes- distance
class Run : Activity
{
    private double _distance;
    public Run(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
    public double GetDistance()
    { return _distance; }
    public void ListGetSummary(Run act)
    {
        Console.WriteLine($"{act.GetDate()} {act.GetType()}- Distance: {act.GetDistance()} miles, Speed: {CalcSpeed(act.GetDistance(), act.GetDuration())} , Pace: {CalcPace(act.GetDuration(), act.GetDistance())}");
    }

    public void GetSummary(Activity act, string date, double duration, double distance)
    {
        Console.WriteLine($"{date} {act.GetType()}- Distance: {distance} miles, Speed: {CalcSpeed(distance, duration)} , Pace: {CalcPace(duration, distance)}");
    }
}
