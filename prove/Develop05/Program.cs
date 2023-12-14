using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        Console.WriteLine($"You have {gm._points} points.\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1 Create New Goal\n 2 list Goals\n 3 Save Goals\n 4 Load Goals\n 5 Record Event\n 6 Quit \nSelect a choice from the menu: ");
        string choice = Console.ReadLine();
        
        if (choice == "1")
        {
            CreateGoal();
        }
        
        else if (choice == "2")
        {
            ListGoalNames();
        }

        else if (choice == "3")
        {
            SaveGoals()
        }

        else if (choice == "4")
        {
            LoadGoals();
        }

        else if (choice == "5")
        {
            RecordEvent();
        }

    }


}