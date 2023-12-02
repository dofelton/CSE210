using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public ReflectingActivity() : base()
    {
        _name = "Reflecting";
        _description = "Welcome to the Reflecting Activity.\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
        
    }

    public void Run()
    {
        DisplayStartMessage(_description);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Get ready...");
            Console.WriteLine(GetRandomPrompt());
            Thread.Sleep(1000);
            Console.WriteLine(GetRandomQuestion());
            Thread.Sleep(1000);
            while (endTime > DateTime.Now)
            {
                ShowDuration();
            }
        }
        Console.WriteLine("");
        EndMessage();
    }

    private string GetRandomPrompt()
    {
            Random rnd = new Random();
            int num = rnd.Next(0, _prompts.Count());
            return _prompts[num];
    }

    private string GetRandomQuestion()
    {
            Random rnd = new Random();
            int num = rnd.Next(0, (_questions.Count()) - 1);
            return _questions[num];
    }
}