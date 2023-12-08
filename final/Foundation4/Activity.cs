// Attributes- date, duration in minutes
//  methods- calculate distance, speed, pace, GetSummary

class Activity
{
    private string _date; { get; set; }
    private int _duration; { get; set; }

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }


}