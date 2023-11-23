using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference r1 = new Reference();
        string reference = r1.DisplayReference();
        Scripture s1 = new Scripture();
        string scripture = s1.ChooseScripture();
        Words w1 = new Words(scripture);
        Console.WriteLine(s1.DisplayScripture(reference, w1.CreateWordList(s1._scripture)));
        Console.WriteLine("");
        
        while (w1.CompletelyHidden() == false)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string end = Console.ReadLine();
            if (end == "quit")
            {
                break;
            }
            else
            {
                w1.HideWords(w1._text);
                Console.WriteLine(s1.DisplayScripture(reference, w1._text));

            }
        }
    }
}
// ChooseScripture()
// loop accepting user input
    // if Enter is pressed continue
    // type quit to exit program