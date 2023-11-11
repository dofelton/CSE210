using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        
        int userNum = PromptUserNumber();
        
        int sqrNum = SquareNumber(userNum);
        
        DisplayResult(userName, sqrNum);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string strNum = Console.ReadLine();
        int num = Convert.ToInt32(strNum);
        return num;
    }
    
    static int SquareNumber(int num)
    {
        int sqrNum = num * num;
        return sqrNum;
    }
    
    static void DisplayResult(string name, int sqrNum)
    {
        Console.WriteLine($"{name}, the square of your number is {sqrNum}");
    }    
}