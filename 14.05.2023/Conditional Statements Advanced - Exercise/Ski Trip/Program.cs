using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string assessment = Console.ReadLine();
            double priceForNight = 0;
            double sum = 0;
            if (typeRoom == "room for one person") { priceForNight = 18;  }
            else if (typeRoom == "apartment") { priceForNight = 25; }
            else if (typeRoom == "president apartment") { priceForNight = 35; }
            sum = (days - 1) * priceForNight;
            if (days > 15)
            {
                if (typeRoom == "apartment") { sum = sum - 0.5 * sum; }
                else if (typeRoom == "president apartment") { sum = sum - 0.2 * sum; }
            }
            else if (days >= 10 & days <= 15)
            {
                if (typeRoom == "apartment") { sum = sum - 0.35 * sum; }
                else if (typeRoom == "president apartment") { sum = sum - 0.15 * sum; }
            }
            else
            {
                if (typeRoom == "apartment") { sum = sum - 0.3 * sum; }
                else if (typeRoom == "president apartment") { sum = sum - 0.1 * sum; }
            }
            if (assessment == "positive")
            { sum = sum + sum * 0.25; }
            else if (assessment == "negative") { sum = sum - 0.1 * sum; }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
