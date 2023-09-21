using System;

namespace Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string opinion = Console.ReadLine();
            double sum = 0;
            int nights = days - 1;
            if (days < 10)
            {
                switch (type)
                {
                    case "room for one person": sum = 18 * nights; break;
                    case "apartment": sum = nights * 25; sum = sum - sum * 0.30; break;
                    case "president apartment": sum = nights * 35; sum = sum - sum * 0.1; break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (type)
                {
                    case "room for one person": sum = 18 * nights; break;
                    case "apartment": sum = nights * 25; sum = sum - sum * 0.35; break;
                    case "president apartment": sum = nights * 35; sum = sum - sum * 0.15; break;
                }
            }
            else if (days > 15)
            {
                switch (type)
                {
                    case "room for one person": sum = 18 * nights; break;
                    case "apartment": sum = nights * 25; sum = sum - sum * 0.50; break;
                    case "president apartment": sum = nights * 35; sum = sum - sum * 0.20; break;
                }
            }
            if (opinion == "positive")
            { sum = sum + sum * 0.25; }
            else if (opinion == "negative")
            { sum = sum - sum * 0.1; }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
