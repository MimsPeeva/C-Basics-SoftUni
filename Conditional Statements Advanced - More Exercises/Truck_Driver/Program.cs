using System;

namespace Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmInMonth = double.Parse(Console.ReadLine());
            double sum = 0;
            if (kmInMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = kmInMonth * 0.75 * 4;
                }
                else if (season == "Summer") { sum = kmInMonth * 0.9 * 4; }
                else if (season == "Winter") { sum = kmInMonth * 1.05 * 4; }
            }
            else if (kmInMonth > 5000 & kmInMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    sum = kmInMonth * 0.95 * 4;
                }
                else if (season == "Summer") { sum = kmInMonth * 1.1 * 4; }
                else if (season == "Winter") { sum = kmInMonth * 1.25 * 4; }
            }
            else if (kmInMonth>10000&&kmInMonth<=20000)
            {
                                   sum = kmInMonth * 1.45 * 4;
                           }
            sum = sum - sum * 0.1;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
