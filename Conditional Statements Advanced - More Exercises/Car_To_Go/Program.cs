using System;

namespace Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string type = String.Empty;
            string car = String.Empty;
            double sum = 0;
            if (budget <= 100) { type = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio"; sum = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep"; sum = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500) { type = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio"; sum = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep"; sum = budget * 0.8;
                }
            }
            else if (budget > 500)
            { type = "Luxury class";
                                   car = "Jeep"; sum = budget * 0.9;
               }
            Console.WriteLine(type);
            Console.WriteLine($"{car} - {sum:f2}");
        }
    }
}
