using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNum = Console.ReadLine();
        int magic = int.Parse(magicNum);

        int guess = 0;
        do
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);
            
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower"); 
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }

        } while (magic != guess);
        
    }
}