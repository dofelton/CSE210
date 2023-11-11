using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";

        /* step 1
        if (grade >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else
        {
            Console.WriteLine("Your grade is an F.");
        } */

        //Step 2
        if (grade >= 70)
        {
            Console.WriteLine("Well Done you passed!");
        }
        else
        {
            Console.WriteLine("Work harder next time, you failed.");
        }

        //step 3
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
    }
}