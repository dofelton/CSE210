using System.IO;

public class GoalManager
{
    private List<string> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        List<string> _goals = new List<string>();
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_score}")
    }

    public void ListGoalNames()
    {
        int goalNum = 1;
        foreach (List<string> goal in _goals)
        {
            Console.WriteLine($"{goalNum} {goal}");
            goalNum ++;
        }
    }

    // public void ListGoalDetails()
    // {
    //     Console.WriteLine($"{_name}: {_description} Points: {_points}")
    // }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n  1 Simple Goal\n  2 Eternal Goal\n  3 Checklist Goal\n Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            
            Console.WriteLine("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.WriteLine("what is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is it worth?");
            string points = Console.ReadLine();
            
            Simple s1 = new Simple(shortName, description, points);
            _goals.Add($"{s1.GetName()}: {s1.GetDescription()} Points: {s1.GetPoints()}");
        }

        else if (choice == "2")
        {
            Console.WriteLine("What is the name of your goal? ");
            string shortname = Console.ReadLine();
            Console.WriteLine("what is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is it worth?");
            string points = Console.ReadLine();
            

            Eternal e1 = new Eternal(shortname, description, points);
            _goals.Add($"{e1.GetName}: {e1.GetDescription} Points: {e1.GetPoints}");
        }

        else if (choice == "3")
        {
            
            Console.WriteLine("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.WriteLine("what is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is it worth?");
            string points = Console.ReadLine();
            Console.WriteLine("What is your target number of events? ");
            string stringTarget = Console.ReadLine();
            int target = Convert.ToInt32(stringTarget);
            Console.WriteLine("How many bonus points for reaching your target? ");
            string bonusString = Console.ReadLine();
            int bonus = Convert.ToInt32(bonusString);

            Checklist c1 = new Checklist(shortName, description, points, target, bonus);
            _goals.Add($"{c1.GetName},: {c1.GetDescription}, Points: {c1.GetPoints}, Target: {c1.GetTarget}, Bonus Points: {c1.GetBonus}");

        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you complete? ");
        string strIndex = Console.ReadLine();
        int index = Convert.ToInt32(strIndex);

        _score = _score + _goals[index];

    }

    public void SaveGoals()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter (fileName))
        {
            foreach (List<string> goal in _goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What file would you like to load? ");
        string fileName = Console.ReadLine();

    }
}