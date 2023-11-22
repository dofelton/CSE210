using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Classes
            // journal, entry
        //methods
            // new entry-Entry
            // display journal entries-Entry

            // save the journal-Journal

            // load journal from file-Journal

            // provide a menu- Main

        int choice;
        Entry e1 = new Entry();
        Journal j1 = new Journal();
        do {
        Console.WriteLine("Please select one of the following choices:\n1) New entry \n2) Display journal entries \n3) Save the journal to a file \n4) Load the journal from a file\n5) Quit");
        string choiceString = Console.ReadLine();
        choice = Convert.ToInt32(choiceString);

        if (choice == 1)
        {
            j1.AddEntry();
            Console.WriteLine(j1._todayEntry);
        }
        else if (choice == 2)
        {
            j1.DisplayAll();
        }
        else if (choice == 3)
        {
            j1.SaveToFile();
        }
        else if (choice == 4)
        {
            j1.LoadFromFile();
        }
        } while(choice != 5);
    }
}