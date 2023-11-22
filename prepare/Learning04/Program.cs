using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Roberto", "Math Assignment");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Roberto", "Writing", "The Cause of War");
        Console.WriteLine(a3.GetWritingInformation());
    }
}