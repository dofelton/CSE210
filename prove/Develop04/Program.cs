using System;

class Program
{
    static void Main(string[] args)
    {        
        Console.Clear();
        Console.WriteLine("Menu Options:\n  1 Start breathing activity\n  2. Start reflection activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
        string choiceString = Console.ReadLine();
        int choice = Convert.ToInt32(choiceString);

        if (choice == 1)
        {
            Breathing b1 = new Breathing();
            b1.Run();
        }

        else if (choice == 2)
        {
            ReflectingActivity r1 = new ReflectingActivity();
            r1.Run();
        }
        else if (choice == 3)
        { 
           Listing l1 = new Listing(3);
           l1.Run();
        }

    }
}