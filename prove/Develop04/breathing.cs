using System;

public class Breathing : Activity
{
    private string _message;
    public Breathing() : base()
    {
        _name = "Breathing";
        _message = "Welcome to the Breathing Activity.\nThis activity will help you relax by walking you through a breathing excersize.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartMessage(_message);
        // int _duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Get Ready...");
        showSpinner();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Breath out...");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        
        EndMessage();
    }
}