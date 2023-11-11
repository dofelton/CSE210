using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = 0;
        do
        {
            Console.Write("Enter a number: ");
            string num_string = Console.ReadLine();
            num = int.Parse(num_string);
            numbers.Add(num);
        } while (num != 0);
        int sum = 0;
        int avg = 0;
        int largest = 0;
        
        foreach (int number in numbers)
        {
            sum = sum + number;
            
            if (number > largest)
            {
                largest = number;
            }
        }
        avg = sum/(numbers.Count);
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}