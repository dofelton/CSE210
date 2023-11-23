using System;
using System.ComponentModel;

class Activity
{

protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string _name, string _description)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Timer
    {

    }
    
    public int GetDuration()
    {
        Console.WriteLine("How long would you like your activity: ");
        string durationString = Console.ReadLine();
        int duration = Convert.ToInt32(durationString);
        return duration;
    }

    public void ShowDuration()
    {

    }

    public void StartMessage()
    {
        Console.WriteLine("It's time to begin your activity!");
    }
    public void EndMessage()
    {
        Console.WriteLine($"Great job! You have completed {_name} for {_duration} seconds.");
    }
}