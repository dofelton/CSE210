using System.IO;
using System.IO.Enumeration;

public class Journal
{
    public string _todayEntry = "";
    string[] journal = {"This is your personal journal."};
    Entry e1 = new Entry();

    public void DisplayAll()
    {
        foreach (string entry in journal)
        {
        Console.WriteLine($"{entry}");
        }
    }

    public void AddEntry()
    {
        _todayEntry = e1.WriteEntry();
        Console.WriteLine("");
        journal = journal.Append(_todayEntry).ToArray();
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is your file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(journal);
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename to load? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
    }
}