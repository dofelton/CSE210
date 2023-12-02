using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {"What are personal strengths of yours?", "Who are people that you appreciate?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heros?"};
    
    public Listing(int count) : base()
    {
        _name = "Listing";
        _description = "Welcome to the Listing Activity.\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
        _count = count;
    }

    public void Run()
    {
        DisplayStartMessage(_description);
        // int _duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Thread.Sleep(1000);
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Answer the question as many times as possible in the length of time you set.");
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        
        EndMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int num = rnd.Next(0, _prompts.Count());
        return _prompts[num];
    }
    public List<string> GetListFromUser()
    {
        List<string> entries = new List<string>();
        Console.Write(">");
        string entry = Console.ReadLine();
        entries.Add(entry);
        return entries;
    }
}