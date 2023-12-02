using System;
using System.ComponentModel;

public class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("How long, in seconds, would you like for your session? ");
            string stringDuration = Console.ReadLine();
            _duration = Convert.ToInt32(stringDuration);
        }
    public void Timer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {

        }
    }
    
    public int GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        int duration = Convert.ToInt32(durationString);
        return duration;
    }

    public void ShowDuration()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            showSpinner();
        }
    }

    public void showSpinner()
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
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

//  List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
//         int i = 0;
//         string s = animationStrings[i];
//             Console.Write(s);
//             Thread.Sleep(1000);
//             Console.Write("\b \b");

//             i ++;

//             if (i>= animationStrings.Count)
//             {
//                 i=0;
//             }