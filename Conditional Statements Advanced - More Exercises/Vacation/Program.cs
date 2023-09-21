

using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = string.Empty;
            string sleepingPlace = string.Empty;
            double sum = 0;
            if (budget <= 1000)
            {
                sleepingPlace = "Camp";
                if (season == "Summer")
                { location = "Alaska"; sum = budget * 0.65; }
                else if (season == "Winter")
                { location = "Morocco"; sum = budget * 0.45; }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                sleepingPlace = "Hut";
                if (season == "Summer")
                { location = "Alaska"; sum = budget * 0.8; }
                else if (season == "Winter")
                { location = "Morocco"; sum = budget * 0.6; }
            }
            else if (budget > 3000)
            {
                sleepingPlace = "Hotel";
                if (season == "Summer")
                { location = "Alaska"; sum = budget * 0.9; }
                else if (season == "Winter")
                { location = "Morocco"; sum = budget * 0.9; }
            }
            Console.WriteLine($"{location} - {sleepingPlace} - {sum:f2}");
        }
    }
}
