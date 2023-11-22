using System;

public class Entry
{
    private string _prompt;
    private string _newEntry;
    public string _currentEntry;
    string[] _prompts = {"Who was the most interseting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Length);
        string prompt = _prompts[index];
        return prompt;
    }

     private DateTime GetDate()
    {
        DateTime _today = DateTime.Today;
        return _today;
    }

    public string WriteEntry()
    {
        _prompt = GetRandomPrompt();
        Console.WriteLine(_prompt);
        _newEntry = Console.ReadLine();
        _currentEntry = $"{GetDate()}; {_prompt} {_newEntry}\n";
        return _currentEntry;
    }
    
}