// Attributes- date, duration in minutes
//  methods- calculate distance, speed, pace, GetSummary

class Activity
{
    private string _date; 
    private int _duration;
    public double _distance; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    public string GetDate()
    { return _date; }
    public int GetDuration()
    { return _duration; }
    public virtual double CalcDistance(double speed, double duration)
    {
        return (speed * duration)/60;
    }
    public virtual double CalcSpeed(double distance, double duration)
    {
        return (distance/duration) * 60;
        
    }
    public virtual string CalcPace(double duration, double distance)
    {
        return $"{duration/distance} min per mile";
    }
    public void GetSummary(Activity activity, string date, double duration, double distance, double speed)
    {
        Console.WriteLine($"{date} {activity.GetType()}- Distance: {distance} miles, Speed: {speed} , Pace: {CalcPace(duration, distance)}");
    }
public void ListGetSummary(Activity act)
    {
    }    
}