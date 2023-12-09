using System;
using System.Formats.Asn1;
// create one event of each type then call each display method and output to screen(ConsoleWriteLine(DisplayMessage))
// title, description, date, time, address, (speaker, capacity), (weather), ()

class Program
{
    static void Main(string[] args)
    {
        Lectures l1 = new Lectures("How to LIVE!", "A discussion on getting the most out of life", "January 13", "5:32", "24 Bliss Way", "Happy", "TX", "US", "Mr. Knowit", 123);
        Console.Clear();
        l1.DisplayShort(l1.GetType(), l1.GetTitle(), l1.GetDate());
        l1.DisplayStandardDetails(l1.GetTitle(), l1.GetDescription(), l1.GetDate(), l1.GetTime(), l1.GetAddress());
        l1.DisplayFullDetails(l1.GetTitle(), l1.GetDescription(), l1.GetDate(), l1.GetTime(), l1.GetAddress(), l1.GetType(), l1.GetSpeaker(), l1.GetCapacity());

        Outdoor o1 = new Outdoor("Tribute Concert", "Bands playing all of your favorite music!", "June 11", "1:30", "345 Still St", "Corn", "Iowa", "US", "Sunny");
        o1.DisplayShort(o1.GetType(), o1.GetTitle(), o1.GetDate());
        o1.DisplayStandardDetails(o1.GetTitle(), o1.GetDescription(), o1.GetDate(), o1.GetTime(), o1.GetAddress());
        o1.DisplayFullDetails(o1.GetTitle(), o1.GetDescription(), o1.GetDate(), o1.GetTime(), o1.GetAddress(), l1.GetType(), o1.GetWeather());

        Receptions r1 = new Receptions("Wedding", "Celebrate the nuptuals", "October 23", "8:00", "987 Glow Ave", "Valley", "California", "US");
        r1.DisplayShort(r1.GetType(), r1.GetTitle(), r1.GetDate());
        r1.DisplayStandardDetails(r1.GetTitle(), r1.GetDescription(), r1.GetDate(), r1.GetTime(), r1.GetAddress());
        r1.DisplayFullDetails(r1.GetTitle(), r1.GetDescription(), r1.GetDate(), r1.GetTime(), r1.GetAddress(), r1.GetType());
    }
}